using System;

namespace K3_v_2
{
    class Program
    {
        public static double t1 = 5.0 / 3.0, r = 20.0;
        public static double COS(double ugl) { return Math.Cos((ugl * Math.PI) / 180.0); }
        public static double SIN(double ugl) { return Math.Sin((ugl * Math.PI) / 180.0); }
        public static double tM(double t) { return 20 * SIN(Math.PI * t1); }
        public static double Vr() { return 20 * Math.PI * COS(Math.PI * t1); }
        public static double We() { return 0.8 * t1 + 1.0; }
        //public static double alfa() { return tM(t1) / r; }
        //public static double R() { return We() * SIN(alfa()); }
        public static double Ve() { return We() * r; }
        public static double V() { return Math.Sqrt((Vr() * Vr()) + (Ve() * Ve())); }
        public static double W_r_t() { return 20 * Math.PI * Math.PI * (-SIN(Math.PI * t1)); }
        public static double Ee() { return 0.8 * 1.0; }
        public static double W_e_vr() { return Ee() * r; }
        public static double W_e_cs() { return r * We() * We(); }
        public static double W_c(){return 2.0*We()*Vr()*SIN(90);}
        static void Main(string[] args)
        {
            Console.WriteLine("Точка М(t1)={0:f5}", tM(t1));
            Console.WriteLine("Vr={0:f5}", Vr());
            Console.WriteLine("We={0:f5}", We());
            //Console.WriteLine("alfa={0:f5}", alfa());
            //Console.WriteLine("R={0:f5}", R());
            Console.WriteLine("Ve={0:f5}", Ve());
            Console.WriteLine("V={0:f5}", V());
            Console.WriteLine("Wr_t={0:f5}", W_r_t());
            Console.WriteLine("Ee={0:f5}", Ee());
            Console.WriteLine("We_vr={0:f5}", W_e_vr());
            Console.WriteLine("We_cs={0:f5}", W_e_cs());
            Console.WriteLine( "Wc={0:f5}",W_c());
            Console.ReadLine();
        }
    }
}
