namespace Classes
{
    public class Moto : Veiculo
    {
        private static int _rodas = 2;
        private bool Capacete { get; set; }

        public Moto() : base(_rodas)
        {
        }

        public override void Ligar()
        {
            base.SetLigar();
            this.Capacete = true;
        }

        public override void Desligar()
        {
            base.SetDesligar();
            this.Capacete = false;
        }

        public bool UsandoCapacete()
        {
            return this.Capacete;
        }
    }
}
