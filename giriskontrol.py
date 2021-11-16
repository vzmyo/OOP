def kontrol(userName,password):
    if userName == "admin":
        if password == "1234":
            print("Giriş başarılı")
        else:
            print("password Wrong!")
    else:
        print("Username Wrong!")

kontrol("admin","11")
kontrol("adm","11")
kontrol("admin","1234")

        
