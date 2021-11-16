class Ogrenci:

    def __init__(self,ad,soyad,ogrno):
        self.ad = ad
        self.soyad = soyad
        self.ogrno = ogrno

    def BilgiYaz(self):
        print(self.ad + " " + self.soyad + " " + self.ogrno)


class Onlisans(Ogrenci):
    def __init__(self,ad,soyad,ogrno,bolum):
        Ogrenci.__init__(self,ad,soyad,ogrno)
        self.bolum = bolum
    def BilgiYaz(self):
        print(self.ogrno + " " + self.ad + " " + self.soyad + " " +self.bolum)


ogrenci = Ogrenci("Ahmet","Tekin","345554543")
onlisans = Onlisans("Zeynep","Tekin","223344","Bilgisayar Programlama")
ogrenci.BilgiYaz()
onlisans.BilgiYaz()

