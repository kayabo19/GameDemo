using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    internal interface IKampanyaService
    {
        void KampanyaEkle(Kampanya kampanya);
        void KampanyaSil(Kampanya kampanya);
        void KampanyaGuncelle(Kampanya kampanya);
    }
}
