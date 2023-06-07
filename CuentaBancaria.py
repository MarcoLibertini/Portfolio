class Persona:

    def __init__(self, nombre, apellido):
        self.nombre = nombre
        self.apellido = apellido



class Cliente(Persona):

    def __init__(self, nombre, apellido, nroCuenta, balance):
        super().__init__(nombre, apellido)
        self.nroCuenta = nroCuenta
        self.balance = balance

    def __str__(self):
        return f'Nombre: {self.nombre} ' \
               f'Apellido: {self.apellido} ' \
               f'nroDeCuenta: {self.nroCuenta} ' \
               f'Balance: {self.balance}. '

    def depositar(self, deposita):
        self.balance += deposita
        return 'Deposito creado con exito.'

    def retirar(self, retira):
        if retira > self.balance:
            print (f'No posee saldo suficiente para retirar ${retira}.')
        else:
            self.balance -= retira
            print('Retiro con exito.')

def crearCliente():
    nombre = input('Ingrese Nombre: ')
    apellido = input('Ingrese Apellido: ')
    nroCuenta = int(input('Ingrese nro de Cuenta: '))
    balance = int(input('Ingrese Balance $: '))
    return Cliente(nombre, apellido, nroCuenta, balance)

def inicio():
    clientes = []

    while True:
        print('Seleccione una opcion: ')
        print('[1] - Crear Cliente ')
        print('[2] - Depositar Dinero ')
        print('[3] - Retirar Dinero ')
        print('[4] - Salir ')

        opcion = int(input('Ingrese el nro de la opcion: '))

        if opcion == 1:
            cliente = crearCliente()
            clientes.append(cliente)
            print(cliente)
            print('-----------------------------------')
            print("Cliente creado con exito")
            print('-----------------------------------')


        elif opcion == 2:
            for cliente in clientes:
                print(cliente)
                print('-----------------------------------')
            cuentaSeleccionada = int(input('Ingrese el nro de cuenta de cliente que deposita: '))
            for cliente in clientes:
                if cliente.nroCuenta == cuentaSeleccionada:
                    deposita = int(input('Ingrese cantidad a depositar: '))
                    cliente.depositar(deposita)
                    print('Deposito creado con exito.')


        elif opcion == 3:
            for cliente in clientes:
                print(cliente)
                print('-----------------------------------')
            cuentaSeleccionada = int(input('Ingrese el nro de cuenta de cliente que retira: '))
            for cliente in clientes:
                if cliente.nroCuenta == cuentaSeleccionada:
                    retira = int(input('Ingrese cantidad a retirar: '))
                    cliente.retirar(retira)



        elif opcion == 4:
            print('Muchas gracias por pasar.')
            break
        else:
            print('No es una opcion valida. ')
            print('Presione una tecla para continuar...')

inicio()