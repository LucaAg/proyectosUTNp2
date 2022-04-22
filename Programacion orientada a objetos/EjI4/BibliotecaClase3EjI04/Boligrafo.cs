using System;
using System.Text;

namespace BibliotecaClase3EjI04
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        
        public Boligrafo(ConsoleColor color,short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short nuevaTinta)
        {
            short tintaResultante;
            if(GetTinta() > 0 && GetTinta() <= cantidadTintaMaxima)
            {
                tintaResultante = (short) (GetTinta() + nuevaTinta);
                this.tinta = tintaResultante;
                if(tintaResultante < 0 || tintaResultante > 100)
                {
                    this.tinta -= nuevaTinta;   
                }
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto,out string dibujo)
        {
            short tintaUtilizada = 0;
            dibujo = "";
            bool sePinta = false;
            Console.ForegroundColor = this.GetColor();
            if (gasto >= GetTinta())
            { 
                for (Int32 i = 0; i < GetTinta(); i++)
                {
                    tintaUtilizada++;
                }
            }
            else if( gasto < GetTinta())
            {
                tintaUtilizada = gasto ;
            }
            
            if(GetTinta() == 0)
            {
                dibujo = "";
            }
            else
            {
                for (Int32 i = 0; i < tintaUtilizada; i++)
                {
                    dibujo  += "*";
                }
                sePinta = true;
            }
            return sePinta;
        }
    }
}
