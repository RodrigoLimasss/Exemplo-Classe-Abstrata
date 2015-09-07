namespace Classes
{
    public class Carro : Veiculo
    {
        private static int _rodas = 4;
        private bool Cinto { get; set; }

        public Carro() : base(_rodas)
        {
        }

        public override void Ligar()
        {
            base.SetLigar();
            this.Cinto = true;
        }

        public override void Desligar()
        {
            base.SetDesligar();
            this.Cinto = false;
        }

        public bool UsandoCinto()
        {
            return this.Cinto;
        }
    }
}
