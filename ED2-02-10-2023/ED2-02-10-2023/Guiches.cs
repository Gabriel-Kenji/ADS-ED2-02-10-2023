using System.Collections.Generic;

namespace ED2_02_10_2023
{
    public class Guiches
    {
        private List<Guiche> listaGuiches;

        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
        }

        public List<Guiche> ListaGuiches
        {
            get => listaGuiches;
            set => listaGuiches = value;
        }

        public void adicionar(Guiche guiche)
        {
            listaGuiches.Add(guiche);
        }
    }
}