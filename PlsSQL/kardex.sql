

/* Kardex de articulos */  1389 registros

select * from tbl_cli_pedido

select * from tbl_prv_ingreso


select d.codigo,d.descripcion,d.tipo,d.fsistema, d.cantidad from
(
select a.codigo as codigo,
       a.descripcion as descripcion,
       'Pedido' as tipo,
       p.fecha_sistema as fsistema,
       -d.cantidad as cantidad       
  from tbl_cli_pedido p inner join tbl_cli_pedido_det d on d.orden_doc = p.orden
                        inner join tbl_articulo a on a.orden = d.orden_articulo
union all
select a.codigo as codigo,
       a.descripcion as descripcion,
       'IngresoPRV' as tipo,
       p.fecha_sistema as fsistema,
       d.cantidad as cantidad
  from tbl_prv_ingreso p inner join tbl_prv_ingreso_det d on d.orden_doc = p.orden
                         inner join tbl_articulo a on a.orden = d.orden_articulo
union all 
select a.codigo as codigo,
       a.descripcion as descripcion,
       'IngresoMAN' as tipo,
       p.fecha_sistema as fsistema,
       d.cantidad as cantidad
  from tbl_ingreso p inner join tbl_prv_ingreso_det d on d.orden_doc = p.orden 
                     inner join tbl_articulo a on a.orden = d.orden_articulo 
union all 
select a.codigo as codigo,
       a.descripcion as descripcion,
       'SalidaMAN' as tipo,
       p.fecha_sistema as fsistema,
       -d.cantidad as cantidad
  from tbl_salida p inner join tbl_prv_ingreso_det d on d.orden_doc = p.orden  
                    inner join tbl_articulo a on a.orden = d.orden_articulo
) d order by d.codigo, d.fsistema





