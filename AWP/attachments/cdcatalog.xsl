<xsl:stylesheet version="1.0"
xmlns:xsl = "http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
	<html>
	<body>
		<h2> CD Collection </h2>
		<table border="1">
		<tr>
		<th> Artist </th>
		<th> Title </th>
		<th> Price </th>
		</tr>
		<xsl:for-each select="CATALOG/CD">
<!--<xsl:if test="PRICE &gt; 10">-->
			<xsl:sort select="PRICE"/>
			<xsl:choose>
				<xsl:when test="PRICE &gt; 10">
					<tr>
					<td> <xsl:value-of select="ARTIST"/> </td>
					<td> <xsl:value-of select="TITLE"/> </td>
					<td bgcolor="tomato"> <xsl:value-of select="PRICE"/> </td>
					</tr>
				</xsl:when>
				<xsl:otherwise>
					<tr>
					<td> <xsl:value-of select="ARTIST"/> </td>
					<td> <xsl:value-of select="TITLE"/> </td>
					<td bgcolor="gray"> <xsl:value-of select="PRICE"/> </td>
					</tr>
				</xsl:otherwise>
			</xsl:choose>
			<!--</xsl:if>-->
		</xsl:for-each>

	</table>
	</body>
	</html>
</xsl:template>

</xsl:stylesheet>