<?xml version="1.0" encoding="utf-8"?>
<xslt:stylesheet version="1.0" xmlns:xslt="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xslt:output method="xml" indent="yes"/>

    <xslt:template match="/">
      <h4>Cuentas Titulares</h4>
      <table border="2" cellpadding="5">
        <thead>
          <th>Num. Cuenta</th>
          <th>Titular</th>
          <th>Saldo</th>
          <th>Sucursal</th>
        </thead>
        
        <xslt:for-each  select="Banco/Cuenta[CuentaSucursal='Barcelona']">
          <tr align="center">
            <td><xslt:value-of select="@CuentaNum"/></td>
            <td><xslt:value-of select="CuentaNombre"/></td>
            <td><xslt:value-of select="CuentaSaldo"/></td>
            <td><xslt:value-of select="CuentaSucursal"/></td>
            
          </tr>
          
        </xslt:for-each>
      </table>        
    </xslt:template>
</xslt:stylesheet>
