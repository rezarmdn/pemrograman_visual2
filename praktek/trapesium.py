# nama : reza ramadhan
# nim : 200511078
# mata kuliah : pemrograman visual
# kelas: R4/TI 20 D
# tugas : praktikum

from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W


class FrmPersegi:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("750x230")
        self.parent.title(title)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10, background="#C9EEFF")
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label

        Label(mainFrame, text='masukan panjang sisi sejajar atas:',border=0, width=30, font=30, background="#C9EEFF").grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="masukan panjang sisi sejajar bawah:", border=0, width=30, font=30, background="#C9EEFF").grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="masukan tinggi trapesium:", border=0, width=30, font=30, background="#C9EEFF").grid(row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas trapesium:", border=0, width=30, font=30, background="#C9EEFF").grid(row=4, column=0, sticky=W, padx=5, pady=5)


        # pasang textbox
        self.txtpanjang_sisi_sejajar_atas = Entry(mainFrame, border=0, width=30, font=30)
        self.txtpanjang_sisi_sejajar_atas.grid(row=0, column=1, padx=20, pady=5) 
        self.txtpanjang_sisi_sejajar_bawah = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtpanjang_sisi_sejajar_bawah.grid(row=1, column=1, padx=20, pady=5) 
        self.txtTinggi = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtTinggi.grid(row=2, column=1, padx=20, pady=5) 
        self.txtLuas = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtLuas.grid(row=4, column=1, padx=20, pady=5)
        
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung,  border=0, width=15, font=20, background="#FFACAC")
        self.btnHitung.grid(row=3, column=1, padx=5, pady=5)
    
    # fungsi untuk menghitung luas_trapesium 
    def onHitung(self):
        # perhitungan dengan metode Pemrograman  Terstruktur 
        panjang_sisi_sejajar_atas = int(self.txtpanjang_sisi_sejajar_atas.get())
        panjang_sisi_sejajar_bawah = int(self.txtpanjang_sisi_sejajar_bawah.get())
        tinggi = int(self.txtTinggi.get())

        luas_trapesium = self.LuasTrapesium(panjang_sisi_sejajar_atas, panjang_sisi_sejajar_bawah, tinggi)

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas_trapesium))
        
    
    def LuasTrapesium(self, sisi_atas, sisi_bawah, tinggi):
        luas_trapesium = 0.5 * (sisi_atas + sisi_bawah) * tinggi
        return luas_trapesium
        
    
if __name__ == '__main__':  
    root = Tk() 
    aplikasi = FrmPersegi(root, "Program Luas Trapesium = By reza ramadhan")
    root.mainloop()
    