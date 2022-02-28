using System;
using System.Text;
using System.IO;


namespace ConsoleApp28._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;             
            Console.Write("Tapşırığın nömrəsin seçin\n" +
                              "1-15 aralığında bir rəqəm daxil edin:");
            string a = Console.ReadLine();

            int b = Convert.ToInt32(a);
            
            
            if (b>15 || b<1)
            {
                Console.WriteLine("Rəqəm düzgün daxil edilməyib təkrar yoxlayın");
                return;
            }

            switch (b)

            {
                case 1:
                    Console.WriteLine("Tapşırıq nömre 1: \n" +
                        "1) 4 reqemli eded verilib." +
                        " Bu ededin eveline 7 reqemini ," +
                        " axirinada 8 reqemini artir. ");
                    Console.Write("Dördrəqəmli ədəd daxil edin: ");
                    string a1 = Console.ReadLine();
                    int b1 = Convert.ToInt32(a1); 
                    b1 = (b1+ 70000) * 10 + 8;
                    Console.WriteLine($"Alınan rəqəm {b1}") ;

                    break;
                 case 2:
                    Console.WriteLine("Tapşırıq nömre 2: \n" +
                        "2) 3 reqemli eded verilib." +
                        "Bu ededin axirina hemin ededdin ozunu yapishdir.");
                    Console.Write("Üçrəqəmli ədəd daxil edin: ");
                    string a2 = Console.ReadLine();
                    int b2 = Convert.ToInt32(a2);
                    b2 = b2 * 1000 + b2;
                    Console.WriteLine($"Alınan rəqəm {b2}");
                    break;
                case 3:
                    Console.WriteLine("Tapşırıq nömre 3: \n" +
                        "3) 5 reqemli eded verilib." +
                        "Bu ededin evvel 18 % sonra ise 3 % tap.");
                    Console.Write("Beşrəqəmli ədəd daxil edin: ");
                    string a3 = Console.ReadLine();
                    double b3 = Convert.ToInt32(a3);
                    b3 = (b3 * 18 / 100) * 3 / 100;
                    Console.WriteLine($"Alınan rəqəm {b3}");
                    break;
                case 4:
                    Console.WriteLine("Tapşırıq nömre 4: \n" +
                        "4) 3 reqemli eded verilib. " +
                        "Bu ededin axirina 7 artir. " +
                        "Sonra cavabin 7% tap;");
                    Console.Write("Üçrəqəmli ədəd daxil edin: ");
                    string a4 = Console.ReadLine();
                    double b4 = Convert.ToInt32(a4);
                    b4 = (b4 * 10 + 7) * 7 / 100;
                    Console.WriteLine($"Alınan rəqəm {b4}");
                    break;
                case 5:
                    Console.WriteLine("Tapşırıq nomre 5: \n" +
                        "5) 4 reqemli eded verilib." +
                        "Bu ededin evvelin 4 reqemi, " +
                        "axirina ise 44 ededini artir. " +
                        "Alinan cavabin 44 % tap.");
                    Console.Write("Dördrəqəmli ədəd daxil edin: ");
                    string a5 = Console.ReadLine();
                    double b5 = Convert.ToInt32(a5);
                    b5 = ((b5 + 40000) * 100 + 44) * 44 / 100;
                    Console.WriteLine($"Alınan rəqəm {b5}");
                    break;
                case 6:
                    Console.WriteLine("Tapşırıq nömre 6: \n" +
                        "6) 4 reqemli eded verilib. " +
                        "Bu ededin evvel 20%-ni, " +
                        "sonra ise cavabin 10% tap. " +
                        "Alinan cavabin kvadratini tap.");
                    Console.Write("Dördrəqəmli ədəd daxil edin: ");
                    string a6 = Console.ReadLine();
                    double b6= Convert.ToInt32(a6);
                    b6 = (b6 * 2 / 100);
                    b6 = Math.Pow(b6, 2);
                    Console.WriteLine($"Alınan rəqəm {b6}");
                    break;
                case 7:
                    Console.WriteLine("Tapşırıq nömre 7: \n" +
                        "7) 2 dene 5 reqemli eded verilib. " +
                        "Bu ededleri toplayib. " +
                        "Alinan cavabin evveline ve axirina 5 artir. " +
                        "Neticenin 5 % tap");
                    Console.Write("Birinci beşrəqəmli ədəd daxil edin: ");
                    string a71 = Console.ReadLine();
                    double b71 = Convert.ToInt32(a71);
                    Console.Write("Ikinci beşrəqəmli ədəd daxil edin: ");
                    string a72 = Console.ReadLine();
                    double b72 = Convert.ToInt32(a72);
                    double b73 = b71 + b72;
                    string b74 = Convert.ToString(b73); 
                    if (b74.Length==5)
                    {
                        b73 = ((b73 + 500000) * 10 + 5) / 20;
                        Console.WriteLine($"Alınan rəqəm {b73}");
                        return;
                    }
                    else if (b74.Length==7) 
                    {
                        b73 = ((b73 + 5000000) * 10 + 5) / 20;
                        Console.WriteLine($"Alınan rəqəm {b73}");
                    }
                    else
                    {
                        Console.WriteLine("Rəqəm düzgün daxil edilməyib");
                    }
                    break;
                case 8:
                    Console.WriteLine("Tapşırıq nömre 8: \n" +
                        "2 dene eded verilib." +
                        "I eded 4 reqemli II eded 7 reqemlidir." +
                        "I ededin 4 % -ni tap." +
                        "Sonra II ededin 9 % ni tap." +
                        "Sonra Cavalari toplayib 10 % ni tap");
                    Console.Write("Dördrəqəmli ədəd daxil edin: ");
                    string a81 = Console.ReadLine();
                    double b81 = Convert.ToInt32(a81);
                    Console.Write("Yeddirəqəmli ədəd daxil edin: ");
                    string a82 = Console.ReadLine();
                    double b82 = Convert.ToInt32(a82);
                    double b83 = ((b81*4/100) + (b82*9/100))/10;
                    Console.WriteLine($"Alınan rəqəm {b83}");
                    break;
                case 9:
                    Console.WriteLine("Tapşırıq nömre 9: \n" +
                        "9) 3 dene 6 reqemli eded verilib. " +
                        "Her birinin 10 faizini tapib neticeleri topla. " +
                        "Alinan cavabin 10% tap.");
                    Console.Write("Birinci altırəqəmli ədəd daxil edin: ");
                    string a91 = Console.ReadLine();
                    double b91 = Convert.ToInt32(a91);
                    Console.Write("İkinci altırəqəmli ədəd daxil edin: ");
                    string a92 = Console.ReadLine();
                    double b92 = Convert.ToInt32(a92);
                    Console.Write("Üçüncü altırəqəmli ədəd daxil edin: ");
                    string a93 = Console.ReadLine();
                    double b93 = Convert.ToInt32(a93);
                    double b94 = (b91 / 10 + b92 / 10 + b93 / 10) / 10;
                    Console.WriteLine($"Alınan rəqəm {b94}");
                    break;
                case 10:
                    Console.WriteLine("Tapşırıq nömre 10: \n" +
                        "10) 3 dene 4 reqemli eded verilib. " +
                        "I ededin 1%-ni, II ededin 2% , III ededin 3 % tap." +
                        "Neticeleri bir birinden cix." +
                        "Alinan cavabin ustune III ededin 7 % faizini gel");
                    Console.Write("Birinci dördrəqəmli ədəd daxil edin: ");
                    string a101 = Console.ReadLine();
                    double b101 = Convert.ToInt32(a101);
                    Console.Write("İkinci dördrəqəmli ədəd daxil edin: ");
                    string a102 = Console.ReadLine();
                    double b102 = Convert.ToInt32(a102);
                    Console.Write("Üçüncü dördrəqəmli ədəd daxil edin: ");
                    string a103 = Console.ReadLine();
                    double b103 = Convert.ToInt32(a103);                    
                    double b104 = b101 / 100 - b102 / 50 - b103 * 3 / 100 + b103 * 7 / 100;
                    Console.WriteLine($"Alınan rəqəm {b104}");
                    break;
                case 11:
                    Console.WriteLine("Tapşırıq nömre 11: \n" +
                        "11) 4 dene 5 reqemli eded verilib. " +
                        "Her I ededin ustune III ededi gel. " +
                        "II ededin usutune IV ededi gel." +
                        "Sonra cavablari vur birbirine." +
                        "Alinan neticeden III ededin 3 % -ni cix.");
                    Console.Write("Birinci beşrəqəmli ədəd daxil edin: ");
                    string a111 = Console.ReadLine();
                    double b111 = Convert.ToInt32(a111);
                    Console.Write("İkinci beşrəqəmli ədəd daxil edin: ");
                    string a112 = Console.ReadLine();
                    double b112 = Convert.ToInt32(a112);
                    Console.Write("Üçüncü beşrəqəmli ədəd daxil edin: ");
                    string a113 = Console.ReadLine();
                    double b113 = Convert.ToInt32(a113);
                    Console.Write("Dördüncü beşrəqəmli ədəd daxil edin: ");
                    string a114 = Console.ReadLine();
                    double b114 = Convert.ToInt32(a114);
                    double b115 = (b111 + b113) * (b112 + b114) - b113 * 3 / 100;
                    Console.WriteLine($"Alınan rəqəm {b115}");
                    break;
                case 12:
                    Console.WriteLine("Tapşırıq nömre 12: \n" +
                        "4 dene 6 reqemli eded verilib. " +
                        "Ededlerin hamisinin 10 faizini tap ve topla. " +
                        "Sonra hamisinin 15 faizini tap ve topla." +
                        "Sonra yekunda alinanlar iki cavabi vur biri birine." +
                        "Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.");
                    Console.Write("Birinci altırəqəmli ədəd daxil edin: ");
                    string a121 = Console.ReadLine();
                    double b121 = Convert.ToInt32(a121);
                    Console.Write("İkinci altırəqəmli ədəd daxil edin: ");
                    string a122 = Console.ReadLine();
                    double b122 = Convert.ToInt32(a122);
                    Console.Write("Üçüncü altırəqəmli ədəd daxil edin: ");
                    string a123 = Console.ReadLine();
                    double b123 = Convert.ToInt32(a123);
                    Console.Write("Dördüncü altırəqəmli ədəd daxil edin: ");
                    string a124 = Console.ReadLine();
                    double b124 = Convert.ToInt32(a124);
                    double b125 = b121 + b122 + b123 + b124;
                    b125 = ((b125 / 10 * (b125 * 15 / 100))/10)*11/100;
                    Console.WriteLine($"Alınan rəqəm {b125}");
                    break;
                case 13:
                    Console.WriteLine("Tapşırıq nömre 13: \n" +
                        "5 dene eded verilib." +
                        "Bunlardan 3 denesi 5 reqemli. " +
                        "2 denesi ise 3 reqemlidir. " +
                        "5 reqemli ededlerin 5% tap," +
                        "neticeleri vur bir birine." +
                        "Sonra 3 reqemli ededlerin 3 % tap, " +
                        "neticeleri topla." +
                        "Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.");
                    Console.Write("Birinci beşrəqəmli ədəd daxil edin: ");
                    string a131 = Console.ReadLine();
                    double b131 = Convert.ToInt32(a131);
                    Console.Write("İkinci beşrəqəmli ədəd daxil edin: ");
                    string a132 = Console.ReadLine();
                    double b132 = Convert.ToInt32(a132);
                    Console.Write("Üçüncü beşrəqəmli ədəd daxil edin: ");
                    string a133 = Console.ReadLine();
                    double b133 = Convert.ToInt32(a133);
                    Console.Write("Birinci üçrəqəmli ədəd daxil edin: ");
                    string a134 = Console.ReadLine();
                    double b134 = Convert.ToInt32(a134);
                    Console.Write("İkinci üçrəqəmli ədəd daxil edin: ");
                    string a135 = Console.ReadLine();
                    double b135 = Convert.ToInt32(a135);
                    double b136 = ((b131 / 20) * (b132 / 20) * (b133 / 20))/10+
                        ((b134 * 3 / 100) + (b135 * 3 / 100))/10;                    
                    Console.WriteLine($"Alınan ədəd {b136}");
                    break;
                case 14:
                    Console.WriteLine("Tapşırıq nömre 14: \n" +
                        "6 dene 6 reqemli eded verilib. " +
                        "Evvel hamisini topla. " +
                        "Sonra I ve III ededi bir birine yapishdir ve bir eded al." +
                        "I neticeden II neticeni cix." +
                        "Alinan cavabin 10 % tap." +
                        "Neticenin uzerine V ve VI ededleri gel." +
                        "Yekunda alinan cavabin 11 % tap.");
                    Console.Write("Birinci altırəqəmli ədəd daxil edin: ");
                    string a141 = Console.ReadLine();
                    double b141 = Convert.ToInt32(a141);
                    Console.Write("İkinci altırəqəmli ədəd daxil edin: ");
                    string a142 = Console.ReadLine();
                    double b142 = Convert.ToInt32(a142);
                    Console.Write("Üçüncü altırəqəmli ədəd daxil edin: ");
                    string a143 = Console.ReadLine();
                    double b143 = Convert.ToInt32(a143);
                    Console.Write("Dördüncü altırəqəmli ədəd daxil edin: ");
                    string a144 = Console.ReadLine();
                    double b144 = Convert.ToInt32(a144);
                    Console.Write("Beşinci altırəqəmli ədəd daxil edin: ");
                    string a145 = Console.ReadLine();
                    double b145 = Convert.ToInt32(a145);
                    Console.Write("Altıncı altırəqəmli ədəd daxil edin: ");
                    string a146 = Console.ReadLine();
                    double b146 = Convert.ToInt32(a146);
                    double b147 = b141 + b142 + b143 + b144 + b145 + b146;
                    double b148 = b141 * 1000000 + b143;
                    b147 = ((b147 - b148)/10+b145+b146)*11/100;
                    Console.WriteLine($"Alınan ədəd {b147}");
                    break;
                case 15:
                    Console.WriteLine("Tapşırıq nömre 15: \n" +
                        "* 7 dene eded verilib." +
                        "Bunlardan 2 denesi 3 reqemlidir. " +
                        "2 denesi 4 reqemlidir. " +
                        "2 denesi 5 reqemlidir. " +
                        "1 denesi ise 6 reqemlidir." +
                        "3 reqemli ededleri topla, " +
                        "sonra bunlarin ustune gel 4 reqemli ededlerin" +
                        "bir birine vurulmasindan alinan cavabi." +
                        "Sonra neticenin axirina 7 reqemini artir." +
                        "Sonra cavabin ustune gel 5 reqemli ededlerin cemini." +
                        "Sonra neticeden cix 3 reqemli ededlerin bir birine " +
                        "vurulmasindan alinan cavabin axirina 1 artirilmish variantini." +
                        "Sonra alinan cavabin ustune gel 6 reqemli ededi." +
                        "Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini." +
                        "Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap." +
                        "Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.");
                    Console.Write("Birinci üçrəqəmli ədəd daxil edin: ");
                    string a151 = Console.ReadLine();
                    double b151 = Convert.ToInt32(a151);
                    Console.Write("İkinci üçrəqəmli ədəd daxil edin: ");
                    string a152 = Console.ReadLine();
                    double b152 = Convert.ToInt32(a152);
                    Console.Write("Birinci dördrəqəmli ədəd daxil edin: ");
                    string a153 = Console.ReadLine();
                    double b153 = Convert.ToInt32(a153);
                    Console.Write("İkinci dördrəqəmli ədəd daxil edin: ");
                    string a154 = Console.ReadLine();
                    double b154 = Convert.ToInt32(a154);
                    Console.Write("Birinci beşrəqəmli ədəd daxil edin: ");
                    string a155 = Console.ReadLine();
                    double b155 = Convert.ToInt32(a155);
                    Console.Write("İkinci beşrəqəmli ədəd daxil edin: ");
                    string a156 = Console.ReadLine();
                    double b156 = Convert.ToInt32(a156);
                    Console.Write("Altırəqəmli ədəd daxil edin: ");
                    string a157 = Console.ReadLine();
                    double b157 = Convert.ToInt32(a157);
                    double b158 = ((b151 + b152)+ (b153*b154))*10+7; //Sətr 286-294
                    double b159 = (b158 + b155 + b156)-((b151*b152*10)+1)+b157;//S'tr 295-298
                    double b160 = ((((b159 - (b151 + b152 + b153 + b154))
                        * 18 / 100) * 3 / 100) / 100) + b155 + b156;
                    Console.WriteLine($"Alınan ədəd {b160}");
                    break;
            }
            
            
        }
    }
}
