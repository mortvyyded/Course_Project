import tkinter as tk
from tkinter import *
from tkinter import ttk


window = tk.Tk()

window.geometry('600x400')
lbl1 = Label(window, fg='#f00', text="Ответ F =", font=("Arial Bold", 24))
lbl1.grid(column=0, row=0) 
lbl2 = Label(window, fg='#f00', text="Ответ a =", font=("Arial Bold", 24))
lbl2.grid(column=0, row=1)  
lbl3 = Label(window, fg='#f00', text="m =", font=("Arial Bold", 24))
lbl3.grid(column=0, row=2)
lbl4 = Label(window, fg='#f00', text="v0 =", font=("Arial Bold", 24))
lbl4.grid(column=0, row=3)
lbl5 = Label(window, fg='#f00', text="v1 =", font=("Arial Bold", 24))
lbl5.grid(column=0, row=4)
lbl6 = Label(window, fg='#f00', text="t =", font=("Arial Bold", 24))
lbl6.grid(column=0, row=5)


F = tk.IntVar()
nameEntered1 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = F)
nameEntered1.grid(column = 1, row = 0)
a = tk.IntVar()
nameEntered2 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = a)
nameEntered2.grid(column = 1, row = 1)
m = tk.IntVar()
nameEntered3 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = m)
nameEntered3.grid(column = 1, row = 2)
v0 = tk.IntVar()
nameEntered4 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = v0)
nameEntered4.grid(column = 1, row = 3)
v1 = tk.IntVar()
nameEntered5 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = v1)
nameEntered5.grid(column = 1, row = 4)
t = tk.IntVar()
nameEntered6 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = t)
nameEntered6.grid(column = 1, row = 5)


def Rabotai():
	a = v1.get()-v0.get()/t.get()
	F = m.get()*a.get()
	
	nameEntered1.delete(0,"")
	nameEntered1.insert(0,d) 

b1 = Button(text="Решить", width=30, height=3, foreground='#f00', command=Rabotai)
b1.grid(column=1, row=6)

canvas = tk.Canvas(window, height=100, width=400)
image = Image.open("zadacha5.png")
photo = ImageTk.PhotoImage(image)
image = canvas.create_image(0,0, anchor='nw',image=photo)
canvas.grid(row=6,column=1)

window.mainloop()

