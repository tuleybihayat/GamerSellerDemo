using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSellerDemo
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı eklendi: " + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı silindi: " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı güncellendi:" + gamer.FirstName);
        }
    }
}
