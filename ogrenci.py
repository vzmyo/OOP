class Ogrenci:
    ad = ""
    soyad = ""
    ogrno = ""

    def BilgiYaz(self):
        print(self.ad + " " + self.soyad + " " + self.ogrno)

ogrenci = Ogrenci()
ogrenci.ad = "Ahmet"
ogrenci.soyad = "Tekin"
ogrenci.ogrno = "121121212"

ogrenci.BilgiYaz()

