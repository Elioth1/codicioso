using System;
using System.Globalization; 
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Transactions;
using System.Text; //                                 :v

namespace CambioDinero 
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            Console.WriteLine("¿Desea ingresar cantidades enteras? (Poner letra 'n' en caso de poner cantidades con centavos)");
            Console.WriteLine("(Use la letra 'n' para indicar que no o 's' para dar su respuesta como si.)");
            respuesta = Console.ReadKey().KeyChar;
            switch (respuesta)
            {
                case 's':
                {
                    Console.Clear();

                    int Mil,Quini,Doci,Cien,Cincuenta,Veinte,Diez,Cinco,Dos,Uno;
                    string Nombre;

                    Console.Write("Ingrese su nombre: ");
                    Nombre = Console.ReadLine();

                    Console.Write("Ingrese el monto: ");
                    string Monto1 = Console.ReadLine();
            
                    float Monton1 = Convert.ToSingle(Monto1,CultureInfo.InvariantCulture.NumberFormat);
        
                    float Monto3 = Monton1;
                    int Monto = (int)Monto3;
          
                    if (Monto % 1 == 0)
                    {
                        
                        Mil = Monto / 1000;
                        Monto = Monto % 1000;

                        Quini = Monto / 500;
                        Monto = Monto % 500;

                        Doci = Monto / 200;
                        Monto = Monto % 200;

                        Cien = Monto / 100;
                        Monto = Monto % 100;

                        Cincuenta = Monto / 50;
                        Monto = Monto % 50;

                        Veinte = Monto / 20;
                        Monto = Monto % 20;

                        Diez = Monto / 10;
                        Monto = Monto % 10;

                        Cinco = Monto / 5;
                        Monto = Monto % 5;

                        Dos = Monto / 2;
                        Monto = Monto % 2;

                        Uno = Monto / 1;
                        Monto = Monto % 1;

                        Console.Clear();
                        Console.WriteLine($"Cliente:{Nombre}    Cantidad puesta:{Monto3}    Cantidad en cambio.... ");
                        Console.WriteLine("Billete(s) de $1000:  " + Mil);
                        Console.WriteLine("Billete(s) de $500:  " + Quini);
                        Console.WriteLine("Billete(s) de $200:  " + Doci);
                        Console.WriteLine("Billete(s) de $100:  " + Cien);
                        Console.WriteLine("Billete(s) de $50:  " + Cincuenta);
                        Console.WriteLine("Billete(s) de $20:  " + Veinte);
                        Console.WriteLine("Moneda(s) de $10:  " + Diez);
                        Console.WriteLine("Moneda(s) de $5:  " + Cinco);
                        Console.WriteLine("Moneda(s) de $2:  " + Dos);
                        Console.WriteLine("Moneda(s) de $1:  " + Uno);            
                    }else{
                        Console.WriteLine("Monto no valido!!"); 
                    }

                    break;    
                }
                case 'n':
                {
                    Console.Clear();
                    int Mil,Quini,Doci,Cien,Cincuenta,Veinte,Diez,Cinco,Dos,Uno;
                    float Cent = 0.50f;
                    float centi = 0.10f;
                    
                    float unocent = 0.01f;
                                     
                    string Nombre;

                    Console.Write("Ingrese su nombre: ");
                    Nombre = Console.ReadLine();
        
                    Console.Write("Ingrese el monto, (Sin centavos, ejemplo: Si la cantidad total va a ser 45.50, ponga: 45 y en el siguiente campo complete con 0.50): ");
                    string Monto1 = Console.ReadLine();

                    Console.WriteLine("Centavos (Siga la indicación anterior): ");
                    string Monto2 = Console.ReadLine();
                    
            
                    float Monton1 = Convert.ToSingle(Monto1,CultureInfo.InvariantCulture.NumberFormat);
                    float Monton2 = Convert.ToSingle(Monto2,CultureInfo.InvariantCulture.NumberFormat);
                    
                    float Monto3 = Monton1 + Monton2;
                    int Monto = (int)Monto3;
                    
                    if (Monto % 1 == 0)
                    {
                        
                        Mil = Monto / 1000;
                        Monto = Monto % 1000;

                        Quini = Monto / 500;
                        Monto = Monto % 500;

                        Doci = Monto / 200;
                        Monto = Monto % 200;

                        Cien = Monto / 100;
                        Monto = Monto % 100;

                        Cincuenta = Monto / 50;
                        Monto = Monto % 50;

                        Veinte = Monto / 20;
                        Monto = Monto % 20;

                        Diez = Monto / 10;
                        Monto = Monto % 10;

                        Cinco = Monto / 5;
                        Monto = Monto % 5;

                        Dos = Monto / 2;
                        Monto = Monto % 2;

                        Uno = Monto / 1;
                        Monto = Monto % 1;
                    
                        if (Monton2 >= 0.50)
                        {
                            Cent = Monton2 / 0.50f;
                            Monton2 = Monton2 % 0.10f;
                        }else
                        {
                            Cent = 0;
                        }
                        int ValordeCin = (int)Cent;

                        
                        
                            centi = Monton2 / 0.10f;
                            Monton2 = Monton2 % 0.10f;
                            int VelordeDiez = (int)centi + 1;
                        
                        

                        unocent = Monton2 / 0.01f;
                        Monton2 = Monton2 % 0.01f;
                        int ValordeUno = (int)unocent + 1;

                        


                        
                        Console.WriteLine($"Cliente:{Nombre}    Cantidad puesta:{Monto3}    Cantidad en cambio.... ");
                        Console.WriteLine("Billete(s) de $1000:  " + Mil);
                        Console.WriteLine("Billete(s) de $500:  " + Quini);
                        Console.WriteLine("Billete(s) de $200:  " + Doci);
                        Console.WriteLine("Billete(s) de $100:  " + Cien);
                        Console.WriteLine("Billete(s) de $50:  " + Cincuenta);
                        Console.WriteLine("Billete(s) de $20:  " + Veinte);
                        Console.WriteLine("Moneda(s) de $10:  " + Diez);
                        Console.WriteLine("Moneda(s) de $5:  " + Cinco);
                        Console.WriteLine("Moneda(s) de $2:  " + Dos);
                        Console.WriteLine("Moneda(s) de $1:  " + Uno);
                        Console.WriteLine("Moneda(s) de ¢50:  " + ValordeCin);
                        Console.WriteLine("Moneda(s) de ¢10: " + VelordeDiez);
                        Console.WriteLine("Moneda(s) de ¢1: " + ValordeUno); 
                                        
                    }else{
                        Console.WriteLine("Monto no valido!!"); 
                    }
                    break;
                }               
                default:Console.WriteLine(" <== Caracter ingresado no válido, asegurese de seguir las indicaciones.");
                break;
            }
            Console.ReadKey();   
            Console.Clear();         
        }
    }
}
