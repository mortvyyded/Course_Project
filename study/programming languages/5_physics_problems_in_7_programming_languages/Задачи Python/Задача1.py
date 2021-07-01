import tkinter as tk
from tkinter import *
from tkinter import ttk


window = tk.Tk()

window.geometry('600x400')
lbl1 = Label(window, fg='#f00', text="Ответ v =", font=("Arial Bold", 24))
lbl1.grid(column=0, row=0) 
lbl2 = Label(window, fg='#f00', text="S =", font=("Arial Bold", 24))
lbl2.grid(column=0, row=1)  
lbl3 = Label(window, fg='#f00', text="t =", font=("Arial Bold", 24))
lbl3.grid(column=0, row=2)  
 

v = tk.IntVar()
nameEntered1 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = v)
nameEntered1.grid(column = 1, row = 0)
S = tk.IntVar()
nameEntered2 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = S)
nameEntered2.grid(column = 1, row = 1)
t = tk.IntVar()
nameEntered3 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = t)
nameEntered3.grid(column = 1, row = 2)


def Rabotai():
	v = S.get()/(t.get())
	
	nameEntered1.delete(0,"")
	nameEntered1.insert(0,d) 

b1 = Button(text="Решить", width=30, height=3, foreground='#f00', command=Rabotai)
b1.grid(column=1, row=5)

canvas = tk.Canvas(window, height=100, width=400)
image = Image.open("zadacha1.png")
photo = ImageTk.PhotoImage(image)
image = canvas.create_image(0,0, anchor='nw',image=photo)
canvas.grid(row=6,column=1)

window.mainloop()
