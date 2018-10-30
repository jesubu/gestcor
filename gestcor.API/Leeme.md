# Descripcion del proyecto



## Datos
* [X] El contexto es una replesentación de la BD, una representación. Hereda de DbContext.

## Proyecto + planificación 
### Cálculo de fechas de cuotas
* [X] Ajustar las fechas de las cuotas para que no sean mayores que la fecha fin del contrato, incluyendo la planificación por cuotas.
* [X] En caso de planificación por cuotas, se usarán días como incremento de la fecha de las cuotas. El número de días entre cuotas será el resultado de hallar el número de días de vigencia de la oferta y dividirlo entre el número de cuotas. Por definición, el número máximo será el número de días de vigencia de la oferta.
* [X] En caso de tener cuotas facturadas, el número mmínimo de cuotas será el número de facturadas más una. Por definición, el número máximo será el número de días de vigencia de la oferta.
 
### Vinculación cuotas y planificación de muestras/trabajos
* [ ] Nuevo check para vincular cuotas a planificación de muestras.
    * [ ] **NO** vinculado: cantidades independientes.
    * [ ] **SI** vinculado: las cantidades de las cuotas serán las del mes correspondiente. En caso de tener una planificación por cuotas, el monto total del mes se repartirá por igual entre las cuotas del mes.
    * [ ] Cambio de **no** a **si** vinculado lanzará un recalculo de las cuotas no facturadas. Respecto al punto anterior, el recalculo por cuotas repartirá lo no facturado en el mes entre las cuotas no facturadas.
    * [ ] Los checks de las cuotas tendrán relación con el check del vincular cuotas: si la check está activo, **todos** los checks de "A facturar" aparecerán activos. En caso contrario, todos desactivos. Si la cuota está facturada, no aplica => será el valor recibido desde X3 y no se modificará.
 
### Cálculo de cantidades de cuotas
El cálculo de las cuotas será el siguiente:
* [ ] En caso de vinculación entre muestras y cuotas, la cantidad a usar para cada mes será la planificada para ese mes.
* [ ] Cantidad a repartir = Cantidad Total - Cantidad ya facturada
* [ ] Número de cuotas a usar = número total de cuotas - cuotas ya facturadas
* [ ] En caso de cuotas por número de días, la cantidad debería ser proporocional al número de días del mes que cubra cada cuota.

### Campo importe total
* [ ] El campo "Importe total" sólo se modificará cuando se cambie el número de ATs o se añada uno nuevo. Esto aplica a cualquier situación de la oferta.

### Modificación de una oferta ya aceptada
* [ ] Se sigue permitiendo el cambio en cantidades de ATs y eliminación o adición de ATs.
* [ ] Se planificará tanto muestras como cantidades en función de las normas existentes, de los checks y tipos de pagos y de las cuotas que puedan ya estar facturadas.

### Opción de cancelar contrato
* [ ] Nueva opción en el listado de ofertas.
* [ ] Establece la fecha fin de contrato a la fecha del momento en el que se realiza la operativa.
* [ ] Poner los importes de todas las cuotas restantes por facturas a cero.
* [ ] Dejar el contrato con estado "Aceptado"

## Otros trabajos hechos o revisados
- [X] La oferta puede cambiar de proyecto a no proyecto en cualquier momento. La forma de facturación y pago no se puede cambiar si la oferta ya está guardada.
