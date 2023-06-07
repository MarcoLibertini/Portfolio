def decoradorDeTurno(turno):
    print("*" * 23)
    print(f'Su turno es: ')
    if turno == 1:
        print(next(p))
    elif turno == 2:
        print(next(f))
    else:
        print(next(c))
    print(f'En breve seras atendido.')
    print("*" * 23 + "\n")


def turnosFarmacia():
    for i in range(1, 301):
        yield f'F-{str(i).zfill(3)}'


def turnosComestica():
    for i in range(1, 301):
        yield f'C-{str(i).zfill(3)}'


def turnosPerfumeria():
    for i in range(1, 301):
        yield f'P-{str(i).zfill(3)}'


p = turnosPerfumeria()
f = turnosFarmacia()
c = turnosComestica()




