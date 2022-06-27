using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.Components.Properties;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sas.Restaurant.Components.CallerId
{
    public class CallerId
    {
        AlertControl alertControl;
        public event EventHandler<CallerIdEventArgs> AlertYeniKayit;
        public event EventHandler<CallerIdEventArgs> AlertYeniSiparis;
        [DllImport("cid.dll", EntryPoint = "CidData", CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string CidData();

        [DllImport("cid.dll", EntryPoint = "CidStart")]
        public static extern string CidStart();
        private Timer timer;
        RestaurantWorker worker = new RestaurantWorker();
        private XtraForm _form;
        private Telefon telefonBilgi;
        public CallerId(XtraForm form)
        {
            worker = new RestaurantWorker();
            alertControl = new AlertControl();
            alertControl.AutoFormDelay = 10000;
            alertControl.Buttons.Add(new AlertButton
            {
                Name = "YeniKayitEkle",
                Image = Resources.user
            });


            alertControl.Buttons.Add(new AlertButton
            {
                Name = "YeniSiparis",
                Image = Resources.box_into
            });
            alertControl.ButtonClick += AlertButtonClick;
            
            _form = form;
            timer = new Timer(TimerElapsed,null,0,100);
            CidStart();
        }

        private void AlertButtonClick(object sender, AlertButtonClickEventArgs e)
        {
            if (e.ButtonName== "YeniKayitEkle")
            {
                AlertYeniKayit?.Invoke(this, new CallerIdEventArgs
                {
                    Telefon = telefonBilgi
                });
            }
            else if (e.ButtonName=="YeniSiparis")
            {
                AlertYeniSiparis?.Invoke(this, new CallerIdEventArgs
                {
                    Telefon = telefonBilgi
                });
            }
           
        }

        private void TimerElapsed(object state)
        {
            string temp = "";
            temp = CidData();
            if (!String.IsNullOrEmpty(temp))
            {
                string[] tempData = temp.Split(',');
                string telefon = tempData[2];
                if (tempData[2].StartsWith("+90"))
                {
                    telefon = tempData[2].Remove(0, 3);
                }
                if (tempData[2].StartsWith("0"))
                {
                    telefon = tempData[2].Remove(0,1);
                }

                
                Telefon musteri=worker.TelefonService.Get(c=>c.Telefonu==telefon,c=>c.Musteri);
                alertControl.ShowPinButton = false;
                if (musteri==null)
                {
                    telefonBilgi = new Telefon
                    {
                        Telefonu = telefon
                    };
                    alertControl.Buttons[1].Visible = false;
                    alertControl.Buttons[0].Visible = true;
                    worker.AramaKaydiService.Add(new AramaKaydi
                    {
                        Telefon = telefon
                    });

                    _form.Invoke((Action)delegate
                   {
                       alertControl.Show(_form, tempData[1] + " Hattan Aranıyorsunuz", telefon + "\n Kayıtsız müşteri numarası");
                   });
                    
                }
                else
                {
                    telefonBilgi = musteri;
                    alertControl.Buttons[0].Visible = false;
                    alertControl.Buttons[1].Visible = true;
                    worker.AramaKaydiService.Add(new AramaKaydi
                    {
                        Telefon = telefon,
                        MusteriId=musteri.MusteriId
                    });
                    _form.Invoke((Action)delegate
                    {
                        alertControl.Show(_form, tempData[1] + " Hattan Aranıyorsunuz", telefon + "\n" + musteri.Musteri.Adi + " " + musteri.Musteri.Soyadi);
                    });
                    
                }
                worker.Commit();
            }
        }
    }

    public class ConstCharPtrMarshaler : ICustomMarshaler
    {
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            return Marshal.PtrToStringAnsi(pNativeData);
        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            return IntPtr.Zero;
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
        }

        public void CleanUpManagedData(object ManagedObj)
        {
        }

        public int GetNativeDataSize()
        {
            return IntPtr.Size;
        }

        static readonly ConstCharPtrMarshaler instance = new ConstCharPtrMarshaler();

        public static ICustomMarshaler GetInstance(string cookie)
        {
            return instance;
        }
    }
}
