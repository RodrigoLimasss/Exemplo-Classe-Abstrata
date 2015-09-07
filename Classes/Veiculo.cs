namespace Classes
{
    public abstract class Veiculo
    {
        protected int Rodas;
        private bool Ligado { get; set; }

        protected Veiculo(int rodas)
        {
            Rodas = rodas;
        }

        public abstract void Ligar();
        public abstract void Desligar();

        public int GetRodas()
        {
            return this.Rodas;
        }

        protected void SetLigar()
        {
            this.Ligado = true;
        }

        protected void SetDesligar()
        {
            this.Ligado = false;
        }

        public bool IsLigado()
        {
            return Ligado;
        }
    }
}
