# nama : reza ramadhan
# nim : 200511078
# mata kuliah : pemrograman visual
# kelas: R4/TI 20 D
# tugas : praktikum

from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W


class FrmPersegi:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("370x290")
        self.parent.title(title)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10, background="#C9EEFF")
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label

        Label(mainFrame, text='Panjang:',border=0, width=30, font=30, background="#C9EEFF").grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Lebar:", border=0, width=30, font=30, background="#C9EEFF").grid(row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling Layang-Layang Adalah:", border=0, width=30, font=30, background="#C9EEFF").grid(row=6, column=0, sticky=W, padx=5, pady=5)


        # pasang textbox
        self.txtPanjang = Entry(mainFrame, border=0, width=30, font=30)
        self.txtPanjang.grid(row=2, column=0, padx=5, pady=5) 
        self.txtLebar = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtLebar.grid(row=4, column=0, padx=5, pady=5) 
        self.txtKeliling = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtKeliling.grid(row=7, column=0, padx=5, pady=5) 
        
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung,  border=0, width=15, font=20, background="#FFACAC")
        self.btnHitung.grid(row=5, column=0, padx=5, pady=5)
    
    # fungsi untuk menghitung keliling layang-layang 
    def onHitung(self):
        # perhitungan dengan metode Pemrograman  Terstruktur 
        panjang = int(self.txtPanjang.get())
        lebar = int(self.txtLebar.get())

        keliling = self.Keliling(panjang, lebar)

        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(keliling))
        
    
    def Keliling(self, panjang, lebar):
        keliling = (2 * panjang) + (2 * lebar)
        return keliling
        
    
if __name__ == '__main__':  
    root = Tk() 
    aplikasi = FrmPersegi(root, "Program layang-layang = By reza ramadhan")
    root.mainloop()
    