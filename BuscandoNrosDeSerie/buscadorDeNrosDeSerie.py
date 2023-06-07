
import os
from datetime import *
import time
import re

ruta = 'C:\\Users\\enmiv\\Desktop\\PythonT\\BuscandoNrosDeSerie\\Mi_Gran_Directorio'

patron = re.compile(r'\D{1}\w{3}-\d{5}')

fechaDeBusqueda = date.today()
fechaDeBusquedaFormat = fechaDeBusqueda.strftime('%d/%m/%y')

def buscador(ruta, patron):
    dic = {}
    for carpeta, subcarpeta, archivos in os.walk(ruta):
        for arch in archivos: #para cada archivo
            if arch.endswith('.txt'): #si termina con .txt
                try:
                    with open(os.path.join(carpeta, arch),'r') as archivo:
                            contenido = archivo.read() #almaceno el archivo abierto
                            archivoEncontrado = patron.findall(contenido) #busco el patron y el resultado esta en archivo
                            if archivoEncontrado: #SI encontro UNO
                                dic[arch] = archivoEncontrado #lo agrego al diccionario para poder imprimirlo luego
                except:
                    print(f'\t No se pudo abrir el documento {arch}')
    return dic

def impresion(dic, fecha):
    print(f'Fecha de Busqueda: {fecha}')
    print('------------------------------------------')
    print(f"ARCHIVO\t \t\t\tNRO. SERIE\n{'-' * 15}\t\t{'-' * 15}")
    for clave, valor in dic.items():
        print(f'{clave} \t {valor[0]}')
    print(f'Numeros Encontrados: {len(dic)}')
    print('------------------------------------------')


inicio = time.time()
resultados = buscador(ruta, patron)
impresion(resultados, fechaDeBusquedaFormat)
duracion = time.time() - inicio

print(f'Duracion de la busqueda: {duracion: .2f} segs')
