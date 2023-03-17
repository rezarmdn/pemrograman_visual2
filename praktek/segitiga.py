# nama : reza ramadhan
# nim : 200511078
# mata kuliah : pemrograman visual
# kelas: R4/TI 20 D
# tugas : praktikum

from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class FrmPersegi:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("570x190")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10, background="#C9EEFF")
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label
        Label(mainFrame, text='Masukan Alas:', border=0, width=15, font=30, background="#C9EEFF").grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Masukan Tinggi:", border=0, width=15, font=30, background="#C9EEFF").grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:", border=0, width=15, font=30, background="#C9EEFF").grid(row=3, column=0, sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtalas = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtalas.grid(row=0, column=1, padx=5, pady=5) 
        self.txttinggi = Entry(mainFrame, border=0, width=30, font=30) 
        self.txttinggi.grid(row=1, column=1, padx=5, pady=5) 
        self.txtLuas = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtLuas.grid(row=3, column=1, padx=5, pady=5) 
        
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung, border=0, width=20, font=30, background="#FFACAC")
        self.btnHitung.grid(row=2, column=1, padx=5, pady=5)
    
    # fungsi untuk menghitung luas segitiga
    def onHitung(self):
        # perhitungan dengan metode Pemrograman  Terstruktur 
        alas = int(self.txtalas.get())
        tinggi = int(self.txttinggi.get())

        luas = self.luasKeliling(alas, tinggi)
        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))

    def luasKeliling(self, alas, tinggi):
        luas = 0.5 * alas * tinggi
        return luas
        
    
    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()
        
    
if __name__ == '__main__':  
    root = Tk() 
    aplikasi = FrmPersegi(root, "Program Luas segitiga by reza ramadhan")
    root.mainloop()
    