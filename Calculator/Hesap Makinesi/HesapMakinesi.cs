using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Hesap Makinesi
        string _islem;
        bool _temizle;
        int _ilk_ekranda_sayi;
        bool sonuc_oldu;
        bool _islem_girildi;
        
        public Form()
        {
            InitializeComponent();
        }
        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        // Sayılar
        private void sayi1_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "1";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "1";
        }

        private void sayi2_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "2";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "2";
        }

        private void sayi3_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "3";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "3";
        }

        private void sayi4_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "4";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "4";
        }

        private void sayi5_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "5";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "5";
        }

        private void sayi6_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "6";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "6";
        }

        private void sayi7_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "7";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "7";
        }

        private void sayi8_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "8";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "8";
        }

        private void sayi9_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "9";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "9";
        }

        private void sayi0_button_Click(object sender, EventArgs e)
        {
            if (sonuc_oldu)
            {
                gosterme_yeri.Text = "";
                sonuc_oldu = false;
            }
            if (_temizle)
            {
                gosterme_yeri.Text = "";
                _temizle = false;
            }
            gecmis_Label.Text += "0";
            if (gosterme_yeri.Text == "0") gosterme_yeri.Text = "";
            gosterme_yeri.Text += "0";
        }

        // İşlem Butonları
        private void topla_button_Click(object sender, EventArgs e)
        {
            if (gosterme_yeri.Text == "")
            {
                MessageBox.Show("Öncelikle Sayı giriniz!", "Uyarı!");
            }
            else
            {
                _islem_girildi = true;
                _temizle = true;
                gecmis_Label.Text += " + ";
                _islem = "+";
                _ilk_ekranda_sayi = Convert.ToInt32(gosterme_yeri.Text);
            }
        }

        private void cikar_button_Click(object sender, EventArgs e)
        {
            if (gosterme_yeri.Text == "")
            {
                MessageBox.Show("Öncelikle Sayı giriniz!", "Uyarı!");
            }
            else
            {
                _islem_girildi = true;
                _temizle = true;
                gecmis_Label.Text += " - ";
                _islem = "-";
                _ilk_ekranda_sayi = Convert.ToInt32(gosterme_yeri.Text);
            }
        }

        private void carp_button_Click(object sender, EventArgs e)
        {
            if (gosterme_yeri.Text == "")
            {
                MessageBox.Show("Öncelikle Sayı giriniz!", "Uyarı!");
            }
            else 
            {
                _islem_girildi = true;
                _temizle = true;
                gecmis_Label.Text += " x ";
                _islem = "x";
                _ilk_ekranda_sayi = Convert.ToInt32(gosterme_yeri.Text);
            }
            
        }

        private void bolum_button_Click(object sender, EventArgs e)
        {
            if (gosterme_yeri.Text == "")
            {
                MessageBox.Show("Öncelikle Sayı giriniz!", "Uyarı!");
            }
            else
            {
                _islem_girildi = true;
                _temizle = true;
                gecmis_Label.Text += " / ";
                _islem = "/";
                _ilk_ekranda_sayi = Convert.ToInt32(gosterme_yeri.Text);
            }
        }

        // Sonuç yeri
        private void esittir_button_Click(object sender, EventArgs e)
        {
            if (gosterme_yeri.Text == "")
            {
                MessageBox.Show("Lütfen öncelikle işlem giriniz!","Uyarı!");

            }
            else if (_islem == "")
            {
                MessageBox.Show("Lütfen öncelikle işlem giriniz!", "Uyarı!");
            }
            else if (_islem_girildi == false)
            {
                MessageBox.Show("En az bir (+),(-),(x),(/) işlemlerinden birini girmelisiniz!", "Uyarı!");
            }
            else
            {
                gosterme_yeri.Focus();
                sonuc_oldu = true;
                int sonuc;
                switch (_islem)
                {
                    case "+":
                        sonuc = _ilk_ekranda_sayi + Convert.ToInt32(gosterme_yeri.Text);
                        break;
                    case "-":
                        sonuc = _ilk_ekranda_sayi - Convert.ToInt32(gosterme_yeri.Text);
                        break;
                    case "x":
                        sonuc = _ilk_ekranda_sayi * Convert.ToInt32(gosterme_yeri.Text);
                        break;
                    case "/":
                        sonuc = _ilk_ekranda_sayi / Convert.ToInt32(gosterme_yeri.Text);
                        break;
                    default:
                        sonuc = 0;
                        break;
                }
                _islem_girildi = false;
                gecmis_Label.Text += " = "+sonuc;
                gosterme_yeri.Text = Convert.ToString(sonuc);
            }   
        }

        // temizle button
        private void ctemizle_button_Click(object sender, EventArgs e)
        {
            gosterme_yeri.Text = "";
            gecmis_Label.Text = "";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Rusy4li Tarafından Kodlanan Hesap Makinesine Hoş geldiniz!\n-> Sol tarafdaki X işaretine Tıklayarak Geçmişi Temizleyebilirsiniz.","Hoşgeldin!",1200);
            gosterme_yeri.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gecmis_Label.Text = "";
        }
    }
}
