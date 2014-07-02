using System;

namespace K2_v_2
{
    class Program
    {
        public static double OA = 30.00, r = 15.00, AC = 8.00, Woa = 3.0, Eoa = 2.0, alfa = 60.0, beta = 45.0;
        public static double COS(double ugl) { return Math.Cos((ugl * Math.PI) / 180.0); }
        public static double SIN(double ugl) { return Math.Sin((ugl * Math.PI) / 180.0); }
        public static double V_a() { return Woa * OA; }
        public static double W_cb() { return V_a() / r; }
        public static double CP() { return Math.Sqrt((AC * AC) + (r * r) - (2.0 * AC * r * COS(alfa + 90.0))); }
        public static double BP() { return Math.Sqrt((r * r) + (r * r) - (2.0 * r * r) * COS(beta + 90.0)); }
        public static double V_b() { return W_cb() * BP(); }
        public static double V_c() { return W_cb() * CP(); }
        public static double W_a() { return OA * Math.Sqrt((Eoa * Eoa) + Math.Pow(Woa, 4)); }
        public static double W_ao_cs() { return (Woa * Woa) * OA; }
        public static double W_ao_vr() { return Eoa * OA; }
        public static double W_ab_cs() { return (W_cb() * W_cb()) * r; }
        public static double W_ab_vr() { return Eoa * r; }
        public static double W_bx() { return -W_ab_cs() + (W_ao_vr() * COS(90.0 - beta)) + (W_ao_vr() * COS(beta)); }
        public static double W_by() { return -W_ab_vr() + (W_ao_cs() * SIN(90.0 - beta)) - (W_ao_vr() * SIN(beta)); }
        public static double W_b() { return Math.Sqrt((W_bx() * W_bx()) + (W_by() * W_by())); }
        public static double W_cx() { return W_ab_vr() + (W_ao_cs() * COS(alfa) + (W_ao_vr() * SIN(alfa))); }
        public static double W_cy() { return (W_ao_cs() * SIN(alfa)) - (W_ao_vr() * COS(alfa)) - W_ab_cs(); }
        public static double W_c() { return Math.Sqrt((W_cx() * W_cx()) + (W_cy() * W_cy())); }
        static void Main(string[] args)
        {
            Console.WriteLine("Va=" + V_a());
            Console.WriteLine("Wcb=" + W_cb());
            Console.WriteLine("CP={0:F5}", CP());
            Console.WriteLine("BP={0:F5}", BP());
            Console.WriteLine("Vb={0:F5}", V_b());
            Console.WriteLine("Vc={0:F5}", V_c());
            Console.WriteLine("Wa={0:F5}", W_a());
            Console.WriteLine("Wb={0:F5}", W_b());
            Console.WriteLine("Wc={0:F5}", W_c());
            Console.ReadLine();
        }
    }
}
