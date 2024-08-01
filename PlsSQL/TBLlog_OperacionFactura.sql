
/*
  Proceso de substitucion de descripcion de log de facturas
  
  1. Verificar con orden_objeto = 0
  select resultado from tbllog_operacion where orden_objeto=0
  
  2. Bk de log
  select * into tbllog_operacion_bk from tbllog_operacion
  
  3. Substitucion verificacion
  SELECT REPLACE(resultado,'Grabado pedido:','Grabado factura:') from tbllog_operacion where orden_objeto=0
  
  4. Substitucion
  update tbllog_operacion set resultado = REPLACE(resultado,'Grabado pedido:','Grabado factura:')  where orden_objeto=0
  
  5. Tipo de onnjeto a 32
  update tbllog_operacion set objeto=32  where orden_objeto=0
  
*/

use ventas

--select * into tbllog_operacion_bk from tbllog_operacion

select * from tbllog_operacion

select * from tbl_cli_pedido where numero_documento =815

select * from tbl_cli_factura where numero_documento =628

--Grabado pedido: 628 cli: 500884-0

select resultado from tbllog_operacion where orden_objeto=0

SELECT REPLACE(resultado,'Grabado pedido:','Grabado factura:') from tbllog_operacion where orden_objeto=0

--update tbllog_operacion set resultado = REPLACE(resultado,'Grabado pedido:','Grabado factura:')  where orden_objeto=0



