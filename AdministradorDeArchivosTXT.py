import os


from pathlib import Path
import shutil

base = Path.home()
ruta = Path(base, 'Recetas') #detallo la carpeta que contiene las recetas
# listadoDeTodaRuta = list(ruta.glob('**/*.txt')) #encuentro todos los archivos
# todosLasRecetas = ruta.glob('**/*.txt')

#pregunto si lo q se encuentra en la ruta es un archivo y no una carpeta
# listaDeRecetas = [receta for receta in listadoDeTodaRuta if receta.is_file()]

#Saco la cantidad de recetas que hay sin directorios
# cantidadDeRecetas = len(listaDeRecetas)


#ubicacion de las recetas
#print(listaDeRecetas)

#cantidad de las recetas
#print(f'La cantidad de recetas es: {cantidadDeRecetas}')

#en una comprension de listas, agrego solo los NAMES (nombre del archivo)
# de las recetas
# nombresDeRecetas = [receta.name for receta in listaDeRecetas]


########################################################

def elegirDirectorio(ruta):
    carpetas = os.listdir(ruta) #solo muestro los directoriso q hay dentro
    print(f'Contenido de ruta: {ruta} ') #Muestro los directorios de la carpeta en la que me encuentro
    for i, carpeta in enumerate(carpetas):
        print(f'[{i+1}] - {carpeta}.')

    eleccion = int(input('Ingrese el nro de la carpeta a explorar: '))
    carpetaElegida = carpetas[eleccion-1]
    return carpetaElegida #retorno la eleccion de la carpeta


def mostrarCarpetas(ruta):
    carpetas = os.listdir(ruta)  # solo muestro los directoriso q hay dentro
    print(f'Contenido de ruta: {ruta} ')  # Muestro los directorios de la carpeta en la que me encuentro
    for i, carpeta in enumerate(carpetas):
        print(f'[{i + 1}] - {carpeta}.')


def mostrarArchivos(ruta, carpeta):
    archivos = Path(os.path.join(ruta, carpeta)) #creo objeto path con la ruta a explorar mas la carpeta q quiero
    rutaFinal = archivos.glob('**/*.txt') #filtro los archivos TODOS
    listaArchivos = [archivo for archivo in rutaFinal if archivo.is_file()] #creo una lista con SOLO LOS ARCHIVOS
    print(f'Contenido de ruta: {archivos} ') #imprimo los archivos q hay
    for i, archivo in enumerate(listaArchivos):
        print(f'[{i + 1}] - {archivo.name}.')


    eleccion = int(input('Ingrese el nro de archivo que quiere leer: '))
    archivoElegido = listaArchivos[eleccion - 1] #voy a retornal la eleccion del archivo a leer
    return archivoElegido


def eliminarCarpeta(ruta):
    carpetas = [nombre for nombre in os.listdir(ruta)]
    print(f'Contenido de ruta: {carpetas} ')  # imprimo los archivos q hay
    for i, carpeta in enumerate(carpetas):
        print(f'[{i + 1}] - {carpeta}.')
    eleccion = int(input('Ingrese el nro de carpeta que quiere eliminar: '))
    carpetaAEliminar = carpetas[eleccion - 1]  # voy a retornal la eleccion del archivo a leer
    confirmacion = input(f'Esta segurx que quiere eliminar " {carpetaAEliminar} " ? (si/no). ')
    if confirmacion.lower() == 'si':
        shutil.rmtree(os.path.join(ruta, carpetaAEliminar))
        print('La carpeta se elimino correctamente')
    else:
        print('Accion cancelada por el usuario')


def volverAtras(ruta): #en la ruta que me posicione vuelve a la anterior
    rutaActual = Path(ruta)
    volverAtras = rutaActual.parent
    return volverAtras

def eliminarArchivo(ruta):
    carpeta = elegirDirectorio(ruta)
    archivos = Path(os.path.join(ruta, carpeta)) #creo objeto path con la ruta a explorar mas la carpeta q quiero
    rutaFinal = archivos.glob('**/*.txt') #filtro los archivos TODOS
    listaArchivos = [archivo for archivo in rutaFinal if archivo.is_file()] #creo una lista con SOLO LOS ARCHIVOS
    print(f'Contenido de ruta: {archivos} ') #imprimo los archivos q hay
    for i, archivo in enumerate(listaArchivos):
        print(f'[{i + 1}] - {archivo.name}.')
    eleccion = int(input('Ingrese el nro de archivo que quiere eliminar: '))
    archivoAEliminar = listaArchivos[eleccion - 1] #voy a retornal la eleccion del archivo a leer
    confirmacion = input(f'Esta segurx que quiere eliminar " {archivoAEliminar.name} " ? (si/no). ')
    if confirmacion.lower() == 'si':
        os.remove(archivoAEliminar)
        print('El archivo se elimino correctamente.')
    else:
        print('Accion cancelada por el usuario')



def leerArchivo(ruta, archivo):
    with open(os.path.join(ruta, archivo), 'r') as archivo:
        contenido = archivo.read()
        archivo.close()
        return contenido


def crearArchivo(ruta):
    #elijo la carpeta
    carpeta = elegirDirectorio(ruta)
    #pido la info para crear el archivo
    nuevoArchivo = input('Ingrese el nombre del archivo:')
    nuevoArchivo += '.txt'
    texto = input('Escriba el texto del archivo.')

    print('El archivo se creo con exito! ')
    #creo el archivo
    with open(os.path.join(ruta, carpeta, nuevoArchivo), 'w') as archivo:
        archivo.write(texto)
        archivo.close()


def crearCarpeta(ruta):
    while True:
        nuevaCarpeta = input('Ingrese el nombre de la nueva carpeta : ')
        #creo la ruta de la nueva carpeta
        carpetaNueva = os.path.join(ruta, nuevaCarpeta)
        # verifico si la carpeta existe
        if os.path.exists(carpetaNueva):
            print(f'La carpeta {nuevaCarpeta} ya existe.')
        else:
            os.mkdir(os.path.join(ruta, nuevaCarpeta))
            break
    print('La carpeta se creo con exito! ')


def menu(ruta):
    os.system('cls')
    print('------------------------------------------')
    print('-------------- Bienvenidx ----------------')
    print('----------- Al aDministrador -------------')
    print('------------------------------------------')
    print(f'Estamos Ubicadxs en: {ruta} ')
    print('------------------------------------------')
    while True:
        print('Seleccione una opcion: ')
        print('[1] - Leer Archivo .txt ')
        print('[2] - Crear archivo .txt ')
        print('[3] - Ver contenido de carpeta ')
        print('[4] - Crear Carpeta ')
        print('[5] - Eliminar archivo .txt ')
        print('[6] - Eliminar carpeta ')
        print('[7] - Finalizar Programa ')

        opcion = int(input('Ingrese el nro de la opcion: '))

        if opcion == 1:
            os.system('cls')
            print(leerArchivo(ruta, mostrarArchivos(ruta, elegirDirectorio(ruta))))



        elif opcion == 2:
            os.system('cls')
            crearArchivo(ruta)


        elif opcion == 3:
            os.system('cls')
            mostrarCarpetas(ruta)


        elif opcion == 4:
            os.system('cls')
            crearCarpeta(ruta)

        elif opcion == 5:
            os.system('cls')
            eliminarArchivo(ruta)


        elif opcion == 6:
            os.system('cls')
            eliminarCarpeta(ruta)


        elif opcion == 7:
            #sale del programa
            break
        else:
            print('No es una opcion valida. ')
            os.system('cls')
            print('Presione una tecla para continuar...')


menu(ruta)