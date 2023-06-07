import numeros

def mostrar():
    print('[1] - Perfumeria ')
    print('[2] - Farmacia ')
    print('[3] - Cosmestica ')
    print('[4] - Salir ')


def menu():
    print('------------------------------------')
    print('-------- Consola de Turnos ---------')
    print('-----------  Farmacia  -------------')
    print('------------------------------------')
    while True:
        mostrar()
        nuevoTurno = int(input('En que sector quiere sacar turno: '))
        if nuevoTurno == 4:
            print('Gracias por visitarnos.')
            break
        elif nuevoTurno not in [1,2,3,4]:
            print('No es una opcion valida.')
        else:
            numeros.decoradorDeTurno(nuevoTurno)

menu()


