# nama : reza ramadhan
# nim : 200511078
# mata kuliah : pemrograman visual
# kelas: R4/TI 20 D
# tugas : praktikum

from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W


class FrmPersegi:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("400x220")
        self.parent.title(title)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10, background="#C9EEFF")
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label

        Label(mainFrame, text='Masukkan sisi persegi / Bujur sangkar:',border=0, width=33, font=30, background="#C9EEFF").grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas Persegi / Bujur sangkar adalah :", border=0, width=33, font=30, background="#C9EEFF").grid(row=4, column=0, sticky=W, padx=5, pady=5)


        # pasang textbox
        self.txtlingkaran = Entry(mainFrame, border=0, width=30, font=30)
        self.txtlingkaran.grid(row=2, column=0, padx=20, pady=5) 
        self.txtLuas = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtLuas.grid(row=5, column=0, padx=20, pady=5) 
        
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung,  border=0, width=15, font=20, background="#FFACAC")
        self.btnHitung.grid(row=3, column=0, padx=5, pady=5)
    
    # fungsi untuk menghitung luas persegi_bujur_sangkar 
    def onHitung(self):
        # perhitungan dengan metode Pemrograman  Terstruktur 
        persegi_bujur_sangkar = int(self.txtlingkaran.get())

        luas = self.Luas(persegi_bujur_sangkar)

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        
    
    def Luas(self, s):
        luas = s * s
        return luas
        
    
if __name__ == '__main__':  
    root = Tk() 
    aplikasi = FrmPersegi(root, "Program Luas persegi/bujur sangkar = By reza ramadhan")
    root.mainloop()
    