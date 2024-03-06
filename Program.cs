using System;
using System.Net;
using System.Drawing;
using System.Text.RegularExpressions;

namespace yes
{
    class Program
    {



static string title;
        
        static void Main(string[] args)
        {



            Random random = new Random();
            string[] ProperNouns = {"Boys","Girl","Woman","Man","Daughter","Son","Father","Mother","TikTok Star","Singer","Passenger","BoyScout","GirlScout","Immigrant","Student","Police Officer"};
            string[] Verb = {"Makes Fun Of","Cheats On","Shames","Is Mean to"};
            string[] GAdjective = {"Ugly","Unpopular","Black","White","Fat","Poor"};
            string[] BAdjective = {"Racist","Mean","Bossy","Gold Digger"};
            string[] End = {"Lives to Regret it", "Happens Next is Shocking","Instantly Regrets it","Instantly Regret it"};
            string[] Gender = {" They"," She"," He"," What"};

            
            

            int G = 3;
            int PNR = random.Next(ProperNouns.Length);
            int PNR2 = random.Next(ProperNouns.Length);
            int VR = random.Next(Verb.Length);
            int GA = random.Next(GAdjective.Length);
            int ER = random.Next(End.Length);
            int BA = random.Next(BAdjective.Length);
            if(PNR2 == PNR){
                PNR2 = random.Next(ProperNouns.Length);
            }
            if(ER != 1){
             if(PNR == 0 || PNR == 3 ||PNR == 5 ||PNR == 6 ||PNR == 11){
               G = 2;
            }
            else if(PNR == 1 ||PNR == 2 ||PNR == 4 ||PNR == 7 ||PNR == 12){
                G = 1;
            }else {
                G = 0;
            }
            }
           if(G == 0){
               ER = 3;
           }

            //Bad adjective - ProperNoun - Verb - GoodGuy adjective - Propernound - Gender/ optional - End
            
            title = BAdjective[BA] +" "+ ProperNouns[PNR] +"\n"+ Verb[VR] +" "+ GAdjective[GA] +"\n"+ ProperNouns[PNR2] +""+ Gender[G] +"\n"+ End[ER];
            
            Console.Write(title);
            download();

           
        }

static void download()
        {
            
            string url = "https://thispersondoesnotexist.com/image";
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(url), "Image.png");
                
                Bitmap bmp = new Bitmap("C:\\Users\\Muheidin\\Desktop\\yes\\blank.png");

                
                
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(Image.FromFile("image.png"),899,0,1024,1091);

                g.DrawImage(Image.FromFile("darrrmen.png"),0,0,1920,1080);







                    string Rtitile = title;
                    
                    


	


                
                    
               
                

                
                g.DrawString(Rtitile, new Font("Tahoma",20), Brushes.Blue,0,100);

                bmp.Save("C:\\Users\\Muheidin\\Desktop\\yes\\output.png");
            }
            
        }
        
    
    }
   




}

/*1/16
1/4
1/6
1/4
1/3
1/3


1.947792 E+6

1.947792 x 10^6*/
//Made By Sly-Bot

