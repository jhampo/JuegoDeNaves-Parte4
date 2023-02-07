using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NaveEspacial
{
    internal class Ventana
    {
        public int Ancho { get; set; }
        public int Altura { get; set; }
        public Point LimiteSuperior { get; set; }
        public Point LimiteInferior { get; set; }
        public ConsoleColor Color { get; set; }

        private Enemigo _enemigo1;
        private Enemigo _enemigo2;
        private List<Bala> _balas;

        public Ventana(int ancho,int altura,ConsoleColor color,Point limiteSuperior,
            Point limiteInferior)
        {
            Ancho = ancho;  
            Altura = altura;
            Color = color;
            LimiteSuperior = limiteSuperior;
            LimiteInferior = limiteInferior;
            Init();
        }
        private void Init()
        {
            Console.SetWindowSize(Ancho,Altura);
            Console.Title = "Nave";
            Console.CursorVisible = false;
            Console.BackgroundColor = Color;
            Console.Clear();
            _enemigo1 = new Enemigo(new Point(50,10),ConsoleColor.Cyan,this,TipoEnemigo.Menu,null);
            _enemigo2 = new Enemigo(new Point(100,30),ConsoleColor.Red,this,TipoEnemigo.Menu,null);
            _balas = new List<Bala>();
            CrearBalas();
        }
        public void DibujarMarco()
        {
            Console.ForegroundColor = ConsoleColor.White;

            for(int i = LimiteSuperior.X; i <= LimiteInferior.X; i++)
            {
                Console.SetCursorPosition(i,LimiteSuperior.Y);
                Console.Write("═");
                Console.SetCursorPosition(i,LimiteInferior.Y);
                Console.Write("═");
            }
            for(int i = LimiteSuperior.Y; i <= LimiteInferior.Y; i++)
            {
                Console.SetCursorPosition(LimiteSuperior.X,i);
                Console.Write("║");
                Console.SetCursorPosition(LimiteInferior.X,i);
                Console.Write("║");
            }

            Console.SetCursorPosition(LimiteSuperior.X,LimiteSuperior.Y);
            Console.Write("╔");
            Console.SetCursorPosition(LimiteSuperior.X,LimiteInferior.Y);
            Console.Write("╚");
            Console.SetCursorPosition(LimiteInferior.X,LimiteSuperior.Y);
            Console.Write("╗");
            Console.SetCursorPosition(LimiteInferior.X,LimiteInferior.Y);
            Console.Write("╝");
        }
        public void Peligro()
        {
            Console.Clear();
            DibujarMarco();
            for (int i = 0; i < 6; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(LimiteInferior.X/2 -5, LimiteInferior.Y/2);
                Console.Write("¡¡PELIGRO!!");
                Thread.Sleep(200);
                Console.SetCursorPosition(LimiteInferior.X / 2 - 5, LimiteInferior.Y / 2);
                Console.Write("           ");
                Thread.Sleep(200);
            }
        }
        public void Menu()
        {
            _enemigo1.Mover();
            _enemigo2.Mover();
            MoverBalas();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(LimiteInferior.X/2 - 5 , LimiteInferior.Y/2 - 1);
            Console.Write("[Enter] JUGAR");
            Console.SetCursorPosition(LimiteInferior.X / 2 - 5, LimiteInferior.Y / 2);
            Console.Write("[Esc] SALIR");
        }
        public void Teclado(ref bool ejecucion,ref bool jugar)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    DibujarMarco();
                    jugar = true;
                }
                if (tecla.Key == ConsoleKey.Escape)
                    ejecucion = false;
            }
        }
        public void CrearBalas()
        {
            Bala bala1 = new Bala(new Point(0,0),ConsoleColor.Red,TipoBala.Menu);
            _balas.Add(bala1);
            Bala bala2 = new Bala(new Point(0, 0), ConsoleColor.DarkMagenta, TipoBala.Menu);
            _balas.Add(bala2);
            Bala bala3 = new Bala(new Point(0, 0), ConsoleColor.Cyan, TipoBala.Menu);
            _balas.Add(bala3);
            Bala bala4 = new Bala(new Point(0, 0), ConsoleColor.DarkBlue, TipoBala.Menu);
            _balas.Add(bala4);
            Bala bala5 = new Bala(new Point(0, 0), ConsoleColor.Gray, TipoBala.Menu);
            _balas.Add(bala5);
            Bala bala6 = new Bala(new Point(0, 0), ConsoleColor.Blue, TipoBala.Menu);
            _balas.Add(bala6);
            Bala bala7 = new Bala(new Point(0, 0), ConsoleColor.DarkRed, TipoBala.Menu);
            _balas.Add(bala7);
            Bala bala8 = new Bala(new Point(0, 0), ConsoleColor.Yellow, TipoBala.Menu);
            _balas.Add(bala8);
            Bala bala9 = new Bala(new Point(0, 0), ConsoleColor.White, TipoBala.Menu);
            _balas.Add(bala9);
            Bala bala10 = new Bala(new Point(0, 0), ConsoleColor.Green, TipoBala.Menu);
            _balas.Add(bala10);
            Bala bala11 = new Bala(new Point(0, 0), ConsoleColor.DarkCyan, TipoBala.Menu);
            _balas.Add(bala11);
            Bala bala12 = new Bala(new Point(0, 0), ConsoleColor.DarkGray, TipoBala.Menu);
            _balas.Add(bala12);
            Bala bala13 = new Bala(new Point(0, 0), ConsoleColor.DarkGreen, TipoBala.Menu);
            _balas.Add(bala13);
            Bala bala14 = new Bala(new Point(0, 0), ConsoleColor.Blue, TipoBala.Menu);
            _balas.Add(bala14);
            Bala bala15 = new Bala(new Point(0, 0), ConsoleColor.Cyan, TipoBala.Menu);
            _balas.Add(bala15);
            Bala bala16 = new Bala(new Point(0, 0), ConsoleColor.Yellow, TipoBala.Menu);
            _balas.Add(bala16);
            Bala bala17 = new Bala(new Point(0, 0), ConsoleColor.Green, TipoBala.Menu);
            _balas.Add(bala17);
            Bala bala18 = new Bala(new Point(0, 0), ConsoleColor.White, TipoBala.Menu);
            _balas.Add(bala18);
            Bala bala19 = new Bala(new Point(0, 0), ConsoleColor.Magenta, TipoBala.Menu);
            _balas.Add(bala19);
            Bala bala20 = new Bala(new Point(0, 0), ConsoleColor.DarkMagenta, TipoBala.Menu);
            _balas.Add(bala20);

            Random random = new Random();

            for (int i = 0; i < _balas.Count; i++)
            {
                PosicionesAleatorias(_balas[i]);
                int numeroAleatorio = random.Next(LimiteSuperior.Y+1,LimiteInferior.Y);
                _balas[i].Posicion = new Point(_balas[i].Posicion.X,numeroAleatorio);
            }
        }
        public void PosicionesAleatorias(Bala bala)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(LimiteSuperior.X+1,LimiteInferior.X);
            bala.Posicion = new Point(numeroAleatorio,LimiteInferior.Y);
        }
        public void MoverBalas()
        {
            for (int i = 0; i < _balas.Count; i++)
            {
                if (_balas[i].Mover(1, LimiteSuperior.Y))
                    PosicionesAleatorias(_balas[i]);
            }
        }
    }
  
}
