namespace consumoEnergia
{
    class Conta
    {
        public int kilowats { get; private set; }
        public double total { get; private set; }
        
        public double adicional = 5;
        public double adicional2 = 3;

        public Cliente titular;

            public Conta (int kilowats)
            {
                this.kilowats = kilowats;
                
            }

            public int setKilowats(int valor)
            {
                return this.kilowats = valor;
            }
            public double setValor(double valor)
            {
                return this.total = valor;
            }

            public double consumo()
            {
                this.total = this.kilowats * this.total;

                for(int i = 50; i <= this.kilowats; i+=50)
                {
                    this.total += this.adicional;
                }

                for(int i = 30; i <= this.kilowats; i+=30)
                {
                    this.total += this.adicional2;
                }
                
                return this.total;
            }
    }
}