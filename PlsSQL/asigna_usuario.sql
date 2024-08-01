

/* debe existir el campo usuario */

/* actualiza el usuario del documento */

declare pedidos cursor 
for
   select 
         orden,
         orden_vendedor
    from tbl_cli_pedido


declare @orden_pedido as integer,
        @orden_vendedor as integer
        
          
 open pedidos
 fetch next from pedidos 
      into  @orden_pedido,
            @orden_vendedor

            
WHILE @@FETCH_STATUS = 0
 begin
     update tbl_cli_pedido set usuario = (select codigo from tbl_vendedor where orden = @orden_vendedor) where orden = @orden_pedido
     fetch next from pedidos 
           into  @orden_pedido,
                 @orden_vendedor    
 end -- lee pedidos
 close pedidos
 deallocate pedidos
 








