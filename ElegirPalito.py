from random import shuffle

#lista inicial
lista = ['-','--','---','---',]


#funcion que mezcla
def mezclar(lista):
    shuffle(lista)
    return lista

#pedirle intento
def probarSuerte():
    intento = ''

    while intento not in ['1','2','3','4']:
        intento = input('Elige un numero del 1 al 4: ')

    return int(intento)

# comprobar intento
def checkear(lista, intento):

    if lista[intento -1] == '-':
        print('A lavar los platos')
    else:
        print(f'te salvaste, elegiste {lista[intento -1]}')

palitos_mezclados = mezclar(lista)
seleccion = probarSuerte()
checkear(palitos_mezclados, seleccion)




