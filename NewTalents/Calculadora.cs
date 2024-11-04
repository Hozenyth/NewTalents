namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listahistorico;
        public Calculadora()
        {
            listahistorico = new List<string>();
            
        }
        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;

            listahistorico.Insert(0, "Val: " + res);
            
            return res;
        }
        public int Subtrair(int val1, int val2)
        {

            return 0;
        }
        public int Multiplicar(int val1, int val2)
        {

            return 0;
        }
        public int Dividir(int val1, int val2)
        {

            return 0;
        }

        public List<string> historico()
        {
            List<string> res;
            listahistorico.RemoveRange(3, listahistorico.Count);
            return listahistorico;
        }
    }
}
