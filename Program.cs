using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    interface IPlayable 
    {
        void Play();  void Pause(); void Stop();
    }
    interface IRecodable
    {
        void Record();  void Pause(); void Stop();
    }
    public class Player: IPlayable, IRecodable
    {
        public void Play() => Console.WriteLine("Play the tune!");
        public void Pause() => Console.WriteLine("Pause the tune!");
        public void Stop() => Console.WriteLine("Stop the tune!");
        public void Record() => Console.WriteLine("Record the tune!");

    }
}
