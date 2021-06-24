import tkinter as tk
from tkinter import *
from tkinter import ttk


window = tk.Tk()

window.geometry('600x400')
lbl1 = Label(window, fg='#f00', text="Ответ S1 =", font=("Arial Bold", 24))
lbl1.grid(column=0, row=0) 
lbl2 = Label(window, fg='#f00', text="Ответ S2 =", font=("Arial Bold", 24))
lbl2.grid(column=0, row=1)  
lbl3 = Label(window, fg='#f00', text="t =", font=("Arial Bold", 24))
lbl3.grid(column=0, row=2)
lbl4 = Label(window, fg='#f00', text="v1 =", font=("Arial Bold", 24))
lbl4.grid(column=0, row=3)
lbl5 = Label(window, fg='#f00', text="v2 =", font=("Arial Bold", 24))
lbl5.grid(column=0, row=4)


S1 = tk.IntVar()
nameEntered1 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = S1)
nameEntered1.grid(column = 1, row = 0)
S2 = tk.IntVar()
nameEntered2 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = S2)
nameEntered2.grid(column = 1, row = 1)
t = tk.IntVar()
nameEntered3 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = t)
nameEntered3.grid(column = 1, row = 2)
v1 = tk.IntVar()
nameEntered4 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = v1)
nameEntered4.grid(column = 1, row = 3)
v2 = tk.IntVar()
nameEntered5 = ttk.Entry(window, width = 30, foreground='#f00', textvariable = v2)
nameEntered5.grid(column = 1, row = 4)


def Rabotai():
	S1 = v1.get()*(t.get())
	S2 = v2.get()*(t.get())
	
	nameEntered1.delete(0,"")
	nameEntered1.insert(0,d) 

b1 = Button(text="Решить", width=30, height=3, foreground='#f00', command=Rabotai)
b1.grid(column=1, row=5)

canvas = tk.Canvas(window, height=100, width=400)
image = Image.open("zadacha4.png")
photo = ImageTk.PhotoImage(image)
image = canvas.create_image(0,0, anchor='nw',image=photo)
canvas.grid(row=6,column=1)

window.mainloop()
