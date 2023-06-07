# ---------------------------------------
# -----           HANGMAN           -----
# ---------------------------------------
import os
from random import *
from os import system

#de manera random el programa elije una palabra de la lista
def elegirPalabra(lista):
    eleccion = choice(lista)
    return eleccion.lower()


# pido la letra al usuario y valido que cumpla la condicion de validarLetra
def pedirLetra():
    while True:
        letra = input('Ingrese una letra: ')
        print('')
        if validarLetra(letra):
            return letra.lower()
        else:
            print ('La letra ingresada no es válida. Ingrese UNA LETRA.')

#valido que sea una letra y no mayor que 1 y otras condiciones
def validarLetra(letra):
    abecedario = 'abcdefghijklmnñopqrstuvwxyz'
    if len(letra) == 1 and letra.isalpha() and letra in abecedario:
        return True
    else:
        return False

#muestro la palabra escondida
def laPalabra(palabra): #muestra la palabra convertida por su cantidad en '_'
    mostrar = '_ ' * len(palabra)
    return mostrar

def arriesgar(arriesga,palabra):
    if arriesga.lower() == palabra.lower(): #el usuario podria arriesgar en una instancia
        return True
    else:
        return False

def letraRepetida(letra, letrasElegidas): #checkea si la letra ya fue elegida
    if letra in letrasElegidas:
        return True
    else:
        return False

def checkearLetra(letras, palabra): #checkea la letra si esta en la palabra
    for letra in palabra:
        if letra in letras:
            return True

    return False


def mostrarPalabra(palabra,letras): #toma la palabra y una lista de letras elegidas
    palabraAMostrar = [] #creo una lista donde almaceno las letras encontradas
    for letra in palabra: #recorro la palabra
        if letra in letras: #si la letra esta en la palabra
            palabraAMostrar.append(letra) #la agrego a la lista
        else:
            palabraAMostrar.append('_') #si no esta agrego un '_'
    return ''.join(palabraAMostrar) #uno toda la lista


def main():
    # lista de palabras a descrubrir
    listaDePalabras = ['imbecil', 'zapallo', 'martillo','manicomio']
    correctas = []
    incorrectas = 0
    vidas = 6
    letrasElegidas = ''

    print('---------------------------------------')
    print('----------   WELLCOME TO    -----------')
    print('-----         THE HANGMAN         -----')
    print('---------------------------------------')

    # uno la funcion que muestra la palabra y la q elije
    palabraElegida = elegirPalabra(listaDePalabras)
    print(f'La Palabra a Adivinar es: {laPalabra(palabraElegida)}')

    while vidas > 0:

        letra = pedirLetra()
        letrasElegidas += letra  # guardo para luego comparar
        if not letraRepetida(letra,correctas): # si la letra no fue ingresada antes entramos a checkear

            if checkearLetra(letra, palabraElegida):
                print('Letra encontrada!')
                correctas.append(letra)
                print(mostrarPalabra(palabraElegida,correctas))
                print('')
                if set(list(palabraElegida)) == set(list(correctas)):
                    print('FELICITACIONES, GANASTE!!')
                    break

            else:
                print('Lo Lamento. Esa letra No esta')
                vidas -= 1
                print(f'Te quedan {vidas} vidas.')
                incorrectas+=1

                if incorrectas == 4: #si se equivoca 4 veces damos la oportunidad de arriesgar
                    respuesta = input('Queres arriesgar con la palabra completa? (si/no) ')
                    if respuesta.lower() == 'si':
                        palabraCompleta = input('Dale ingresa la palabra: ')
                        if arriesgar(palabraCompleta,palabraElegida):
                            print('FELICITACIONES, GANASTE!!')
                            break
                        else:
                            print('No, no era. Perdiste el juego.')
                            break

        else: # Si la letra ya fue ingresada descontamos una vida
            vidas-= 1
            print('Distraidx! ya la habias elegido')
            print(f'Perdes una vida, te quedan {vidas} vidas')


    if vidas == 0:
        print("¡Oh no! Has perdido todas tus vidas. La palabra era: ", palabraElegida)


if __name__ == '__main__':
    main()