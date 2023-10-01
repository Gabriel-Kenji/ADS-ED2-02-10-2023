using System;

namespace ED2_02_10_2023
{
    public class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public Senha(int id)
        {
            this.id = id;
            DateTime data = DateTime.Now;
            this.dataGerac = data.Date;
            this.horaGerac = new DateTime(1,1,1, data.Hour, data.Minute, data.Second);
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public DateTime DataGerac
        {
            get => dataGerac;
            set => dataGerac = value;
        }

        public DateTime HoraGerac
        {
            get => horaGerac;
            set => horaGerac = value;
        }

        public DateTime DataAtend
        {
            get => dataAtend;
            set => dataAtend = value;
        }

        public DateTime HoraAtend
        {
            get => horaAtend;
            set => horaAtend = value;
        }

        public string dadosParciais()
        {
            return this.id.ToString() + " - " + this.dataGerac.ToString("dd/MM/yyyy") + " - " + horaGerac.ToString("HH:mm:ss");
        }
        
        public string dadosCompletos()
        {
            return this.id.ToString() + " - " + this.dataGerac.ToString("dd/MM/yyyy") + " - " + horaGerac.ToString("HH:mm:ss") + " - " + this.dataAtend.ToString("dd/MM/yyyy") + " - " + horaAtend.ToString("HH:mm:ss");
        }
    }
}