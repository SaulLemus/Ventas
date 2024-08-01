

/*
 Script para corregir tipo de objeto, orden de objeto y descripcion en tbllog para facturas
*/

/* Este guarda los numeros de orden de los documentos en el comentario de log
select CAST(SUBSTRING(resultado,19,4 ) as integer) ordenfac into tbl_ordfac
 from tbllog_operacion 
where resultado like 'Grabado factura.:%' and  usuario='recepcion' and CAST(SUBSTRING(resultado,19,4 ) as integer)<1000
*/

/* Muestra los numeros de documento de factura del log
select CAST(SUBSTRING(resultado,19,4 ) as integer) 
 from tbllog_operacion 
where resultado like 'Grabado factura.:%' and  usuario='recepcion' and CAST(SUBSTRING(resultado,19,4 ) as integer)<1000
*/


/* Actualiza el objeto a 32 en recepcion quien es facturadora
--update tbllog_operacion set objeto = 32 where usuario='recepcion' and CAST(SUBSTRING(resultado,19,4 ) as integer) < 1000
*/

/* Muestra los logs que no tienen orden de objeto
select * from tbllog_operacion where objeto =32 and orden_objeto =0
*/

select orden from tbl_cli_factura where numero_documento in (select ordenfac from tbl_ordfac)

/*
update tbllog_operacion 
   set orden_objeto = (select orden from tbl_cli_factura where numero_documento =CAST(SUBSTRING(resultado,19,4 ) as integer)) 
where objeto=32 and orden_objeto=0 and usuario = 'recepcion'
*/

