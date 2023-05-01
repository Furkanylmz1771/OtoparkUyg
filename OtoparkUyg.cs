using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkUyg_
{
    public class OtoparkUyg
    {
        private string ad;

        private int kapasite;
        private double otoparkGeliri;
        private double ticariAracUcreti;
        private double suvAracUreti;
        private int binekAracSayısı;
        private int suvAracSayısı;
        private int ticariAracSayısı;
        private int bosAlanSayısı;
        private int otoparktaKalmaSaati;
        private double otoparkUcreti;
        private double binekAracUcret;

     
        public string Ad
        {
            get { return ad; }      // Bilgi alma
            set { ad = value; }     // Değer aktarma
        }

        public int Kapasite
        {
            get { return kapasite; }
            set
            {
                if (value < 0)
                {
                    kapasite = 0;         // Negatif girişte 0 olarak kabul edilir.
                }
                else
                {
                    kapasite = value;
                }
            }

        }

        public double OtoparkGeliri
        {
            get { return otoparkGeliri; }
            set
            {
                if (value < 0)
                {
                    otoparkGeliri = 0;
                }
                else
                {
                    otoparkGeliri = value;
                }
            }
        }


        public double BinekAracUcret
        {
            get { return binekAracUcret; }
            set
            {
                if (value < 0) binekAracUcret = 0;
                else
                {
                    binekAracUcret = value;
                }


            }


        }

        public double SuvAracUcreti
        {
            get { return suvAracUreti; }
            set
            {
                if (value < 0) suvAracUreti = 0;
                else
                {
                    suvAracUreti = value;
                }

            }

        }


        public double TicariAracUcreti
        {
            get { return ticariAracUcreti; }
            set
            {
                if (value < 0) ticariAracUcreti = 0;
                else
                {
                    ticariAracUcreti = value;
                }

            }

        }




        public int BoşAlanSayısı
        {
            get { return bosAlanSayısı; }
            set
            {
                if (value < 0) bosAlanSayısı = 0;
                else
                {
                    bosAlanSayısı = value;
                }


            }

        }


        public int BinekAracSayısı
        {
            get { return binekAracSayısı; }
            set
            {
                if (value < 0) binekAracSayısı = 0;
                else
                {
                    binekAracSayısı = value;
                }


            }

        }



        public int SuvAracSayısı
        {
            get { return suvAracSayısı; }
            set
            {
                if (value < 0) suvAracSayısı = 0;
                else
                {
                    suvAracSayısı = value;
                }


            }

        }



        public int TicariAracSayısı
        {
            get { return ticariAracSayısı; }
            set
            {
                if (value < 0) ticariAracSayısı = 0;
                else
                {
                    ticariAracSayısı = value;
                }


            }

        }



        public int OtoparktaKalmaSaati
        {
            get { return otoparktaKalmaSaati; }
            set
            {
                if (value < 0) otoparktaKalmaSaati = 0;
                else
                {
                    otoparktaKalmaSaati= value;
                }


            }

        }



        public double OtoparkUcreti
        {
            get { return otoparkUcreti; }
            set
            {
                if (value < 0) otoparkUcreti = 0;
                else
                {
                    otoparkUcreti = value;
                }


            }

        }




        public double TicarİAracUcreti
        {
            get { return ticariAracUcreti; }
            set
            {
                if (value < 0) ticariAracUcreti = 0;
                else
                {
                    ticariAracUcreti = value;
                }


            }

        }




        //  METOTLAR

        public void OtoparkOluşturma(
            string ad,
            int kapasite)
        {
            Ad = ad;
            Kapasite = kapasite;
        }

        public void OtoparkUcretiBelirle(
          double binek,
          double suv,
          double ticari)
        {
            BinekAracUcret = binek;
            SuvAracUcreti = suv;
            TicariAracUcreti = ticari;
        }


        public void OtoparkGirişi(int aracTipi)
        {

            if (aracTipi == 1)
            {
                // binek arac

                BinekAracSayısı++;
                bosAlanSayısı--;
                
            }
            else if (aracTipi == 2)
            {
                // suv arac

                SuvAracSayısı++;
                bosAlanSayısı--;
            }


            else if (aracTipi == 3)
            {
                // ticari arac

                TicariAracSayısı++;
                bosAlanSayısı--;
            }

        }



       public void OtoparkCıkısı(int aracTipi, int saat)
        {
            if(aracTipi == 1)
            {
                if(binekAracSayısı!= 0) {   // Binek arac otoparkta var ise işlemler yapılır.

                    BoşAlanSayısı++;
                    BinekAracSayısı--;
                    OtoparkUcreti = BinekAracUcret * saat;
                    OtoparkGeliri += OtoparkUcreti;
                }

                else if(BinekAracSayısı == 0
                    )
                {
                    Console.WriteLine("Otoparkta binek arac bulunmamaktadır");
                }

            }




            else if(aracTipi == 2)
            {
                if (suvAracSayısı!=0)
                {   // Binek arac otoparkta var ise işlemler yapılır.

                    BoşAlanSayısı++;
                    SuvAracSayısı--;
                    OtoparkUcreti = BinekAracUcret * saat;
                    OtoparkGeliri += OtoparkUcreti;
                }

                else
                {
                    Console.WriteLine("Otoparkta suv arac bulunmamakta");
                }
            }



            else if (aracTipi == 3)
            {
                if (TicariAracSayısı!=0)
                {  

                    BoşAlanSayısı++;
                    TicariAracSayısı--;
                    OtoparkUcreti = TicariAracSayısı * saat;
                    OtoparkGeliri += OtoparkUcreti;
                }

                else
                {
                    Console.WriteLine("Otoparkta ticari arac bulunmamakta");
                }

            }

        }

        public double GelirDurumu()
        {
            return OtoparkGeliri;
        }

        public int BosParkYeriSayısı()
        {
            return BoşAlanSayısı;
        }


    }


    }








   