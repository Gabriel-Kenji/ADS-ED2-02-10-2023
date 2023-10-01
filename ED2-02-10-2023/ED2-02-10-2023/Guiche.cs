using System;
using System.Collections.Generic;

namespace ED2_02_10_2023
{
    public class Guiche
    {
        private int id;
        private  Queue<Senha> atendimentos;

        public Guiche()
        {
            this.atendimentos = new Queue<Senha>();
            this.id = 0;
        }

        public Guiche(int id)
        {
            this.atendimentos = new Queue<Senha>();
            this.id = id;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public Queue<Senha> Atendimentos
        {
            get => atendimentos;
            set => atendimentos = value;
        }

        public bool chamar(Queue<Senha> filaSenha)
        {
            if (filaSenha.Peek() != null)
            {
                Senha senha = filaSenha.Peek();
                DateTime data = DateTime.Now;
                senha.DataAtend = data.Date;
                senha.HoraAtend = new DateTime(1,1,1, data.Hour, data.Minute, data.Second);
                atendimentos.Enqueue(senha);
                filaSenha.Dequeue();
                return true;
            }

            return false;

        }
    }
}