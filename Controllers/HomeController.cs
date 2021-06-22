using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            #region OneCikarilanHouseData
            List<Models.Estate> liste = new List<Models.Estate>
            {               
                new Models.Estate{Photo="../Images/ev1.png", Mahalle="Ertuğrul Gazi Mah.", Sokak="Mutlu Sokak No:22", City="Merkez Bilecik"},
                new Models.Estate{Photo="../Images/ev2.png", Mahalle="Bahçelievler Mah.", Sokak="Yeşil Sokak No:25", City="Merkez Bursa"},
                new Models.Estate{Photo="../Images/ev3.png", Mahalle="Ertuğrul Gazi Mah.", Sokak="Mutlu Sokak No:22", City="Pelitözü Bilecik"},
                new Models.Estate{Photo="../Images/ev3.png", Mahalle="Ertuğrul Gazi Mah.", Sokak="Mutlu Sokak No:22", City="Gülümbe Bilecik"},
            };
            return View(liste);
            #endregion
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Estate()
        {
            #region OneCikarilanHouseData
            List<Models.Estate> estateList = new List<Models.Estate>
            {
                new Models.Estate{Photo="../Images/ev1.png",City="İstanbul",numberAd=120000},
                new Models.Estate{Photo="../Images/ev2.png",City="Ankara",numberAd=110000},
                new Models.Estate{Photo="../Images/ev3.png",City="İzmir",numberAd=100000},
                new Models.Estate{Photo="../Images/ev3.png",City="Tekirdağ",numberAd=50000},
            };
            return PartialView("_Latest", estateList);
            #endregion
        }
            // GET: EstateInfo
        public ActionResult EstateInfo(int id)
        {
            List<Models.Estate> estateList = new List<Models.Estate>
            {
                new Models.Estate{
                    ilanID=1,
                    Mahalle="Pelitözü",
                    Sokak="Ertuğrul Gazi",
                    City="Bilecik",
                    Photo ="/Images/ev1.png",
                    ilanNumber=25051611,
                    metreSquare=140,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=5,
                    kullanimStatus="Temiz",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Yeni badana yapılmış temiz, uygun fiyatlı."
                },
                new Models.Estate{
                    ilanID=2,
                    Mahalle="100.Yıl Mahallesi",
                    Sokak="Mühendis Fatih HAS",
                    City="Tekirdağ",
                    Photo ="/Images/ev2.png",
                    ilanNumber=25321611,
                    metreSquare=120,
                    banyoNumber=1,
                    odaNumber=2,
                    binaAge=1,
                    kullanimStatus="Temiz",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Sıfır bina."
                },
                new Models.Estate{
                    ilanID=3,
                    Mahalle="Nilüfer",
                    Sokak="Osman Gazi",
                    City="Bursa",
                    Photo ="/Images/ev3.png",
                    ilanNumber=3213213,
                    metreSquare=110,
                    banyoNumber=3,
                    odaNumber=2,
                    binaAge=4,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                },
                new Models.Estate{
                    ilanID=4,
                    Mahalle="İstasyon Mahallesi",
                    Sokak="Çiçekciler",
                    City="İstanbul",
                    Photo ="/Images/ev3.png",
                    ilanNumber=3221313,
                    metreSquare=100,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=2,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                }
            };
            var gonder = estateList.SingleOrDefault(x => x.ilanID == id);
            return View("EstateInfo",gonder);            
        }
        public ActionResult Highligths()
        {
            List<Models.Estate> estateList = new List<Models.Estate>
            {
                new Models.Estate{
                    ilanID=1,
                    Mahalle="Pelitözü",
                    Sokak="Ertuğrul Gazi",
                    City="Bilecik",
                    Photo ="../Images/ev1.png",
                    ilanNumber=25051611,
                    metreSquare=140,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=5,
                    kullanimStatus="Temiz",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Yeni badana yapılmış temiz, uygun fiyatlı."
                },
                new Models.Estate{
                    ilanID=2,
                    Mahalle="100.Yıl Mahallesi",
                    Sokak="Mühendis Fatih HAS",
                    City="Tekirdağ",
                    Photo ="../Images/ev2.png",
                    ilanNumber=25321611,
                    metreSquare=120,
                    banyoNumber=1,
                    odaNumber=2,
                    binaAge=1,
                    kullanimStatus="Temiz",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Sıfır bina."
                },
                new Models.Estate{                  
                    ilanID=3,
                    Mahalle="Nilüfer",
                    Sokak="Osman Gazi",
                    City="Bursa",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3213213,
                    metreSquare=110,
                    banyoNumber=3,
                    odaNumber=2,
                    binaAge=4,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                },
                new Models.Estate{                   
                    ilanID=4,
                    Mahalle="İstasyon Mahallesi",
                    Sokak="Çiçekciler",
                    City="İstanbul",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3221313,
                    metreSquare=100,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=2,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                }
            };
            return PartialView("Highligths",estateList);
        }
        public ActionResult AddHouse()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddHouse(Models.Estate addIlan)
        {           
            return View("AddHouse");
        }
        public ActionResult ListHouse()
        {
            List<Models.Estate> listHouse = new List<Models.Estate>
            {
                new Models.Estate{
                    ilanID=1,
                    Mahalle="Pelitözü",
                    Sokak="Ertuğrul Gazi",
                    City="Bilecik",
                    Photo ="../Images/ev1.png",
                    ilanNumber=25051611,
                    metreSquare=140,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=5,
                    kullanimStatus="Temiz",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Yeni badana yapılmış temiz, uygun fiyatlı."
                },
                new Models.Estate{
                    ilanID=2,
                    Mahalle="100.Yıl Mahallesi",
                    Sokak="Mühendis Fatih HAS",
                    City="Tekirdağ",
                    Photo ="../Images/ev2.png",
                    ilanNumber=25321611,
                    metreSquare=120,
                    banyoNumber=1,
                    odaNumber=2,
                    binaAge=1,
                    kullanimStatus="Temiz",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Sıfır bina."
                },
                new Models.Estate{
                    ilanID=3,
                    Mahalle="Nilüfer",
                    Sokak="Osman Gazi",
                    City="Bursa",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3213213,
                    metreSquare=110,
                    banyoNumber=3,
                    odaNumber=2,
                    binaAge=4,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                },
                new Models.Estate{
                    ilanID=4,
                    Mahalle="İstasyon Mahallesi",
                    Sokak="Çiçekciler",
                    City="İstanbul",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3221313,
                    metreSquare=100,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=2,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                },
                new Models.Estate{
                    ilanID=5,
                    Mahalle="İstasyon Mahallesi",
                    Sokak="Çiçekciler",
                    City="İstanbul",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3221313,
                    metreSquare=100,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=2,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                },
                new Models.Estate{
                    ilanID=6,
                    Mahalle="İstasyon Mahallesi",
                    Sokak="Çiçekciler",
                    City="İstanbul",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3221313,
                    metreSquare=100,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=2,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                },
                new Models.Estate{
                    ilanID=7,
                    Mahalle="İstasyon Mahallesi",
                    Sokak="Çiçekciler",
                    City="İstanbul",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3221313,
                    metreSquare=100,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=2,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                },
                new Models.Estate{
                    ilanID=8,
                    Mahalle="İstasyon Mahallesi",
                    Sokak="Çiçekciler",
                    City="İstanbul",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3221313,
                    metreSquare=100,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=2,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                },
                new Models.Estate{
                    ilanID=9,
                    Mahalle="İstasyon Mahallesi",
                    Sokak="Çiçekciler",
                    City="İstanbul",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3221313,
                    metreSquare=100,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=2,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                },
                new Models.Estate{
                    ilanID=10,
                    Mahalle="İstasyon Mahallesi",
                    Sokak="Çiçekciler",
                    City="İstanbul",
                    Photo ="../Images/ev3.png",
                    ilanNumber=3221313,
                    metreSquare=100,
                    banyoNumber=2,
                    odaNumber=3,
                    binaAge=2,
                    kullanimStatus="İkinci El",
                    sahipName="Sahibinden",
                    mobilyaStatus="Eşyasız",
                    homeInfo="Biraz bakımla 10 numara"
                }
            };
            return View("ListHouse",listHouse);
        }
    }
}