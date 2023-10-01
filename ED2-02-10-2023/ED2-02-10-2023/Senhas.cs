using System.Collections.Generic;

namespace ED2_02_10_2023
{
    public class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Senhas()
        {
            this.filaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 1;
        }

        public int ProximoAtendimento
        {
            get => proximoAtendimento;
            set => proximoAtendimento = value;
        }

        public Queue<Senha> FilaSenhas
        {
            get => filaSenhas;
            set => filaSenhas = value;
        }

        public void gerar()
        {
            Senha senha = new Senha(ProximoAtendimento);
            filaSenhas.Enqueue(senha);
        }
    }
}