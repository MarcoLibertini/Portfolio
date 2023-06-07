from random import *

intentos = 0

nombre = input('Hola, como te llamas?')

print(f'Hola {nombre}.')

nroRan = randint(1,10)


while intentos <= 8:
    numero = int(input('Elegi un numero. '))
    if numero < nroRan:
        print('EL NUMERO OCULTO ES MAYOR!')
        intentos += 1
        print(f'te quedan solo {8 - intentos} intentos')
    elif numero > nroRan:
        print('EL NUMERO OCULTO ES MENOR!')
        intentos+=1
        print(f'te quedan solo {8-intentos} intentos')
    else:
        print(f'Lo encontraste el numero es: {nroRan}')
        break;

if intentos == 8:
    print('lo siento perdiste')
