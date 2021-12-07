<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"/>
	<xsl:template match="StudentsDataBase">
		<TABLE BORDER="5">
			<TR>
				<xsl:for-each select="//student">
					<TR>
						<TD>
							<TABLE BORDER="5" WIDTH="1200">
								<TR>
									<th style="width: 10%;">
										<p align="left">Full name</p>
									</th>
									<th style="width:90%;">
										<p align="left">
											<xsl:value-of select="@FULLNAME"/>
										</p>
									</th>
								</TR>
								<TR>
									<th style="width:10%;">
										<p align="left">Group</p>
									</th>
									<th style="width:90%;">
										<p align="left">
											<xsl:value-of select="@GROUP"/>
										</p>
									</th>
								</TR>
								<TR>
								<th style="width:10%;">
									<p align="left">Area of thesis</p>
								</th>
								<th style="width:90%;">
									<p align="left">
										<xsl:value-of select="@AREA_OF_THESIS"/>
									</p>
								</th>
								</TR>
								<TR>
									<th style="width:10%;">
										<p align="left">Professor</p>
									</th>
									<th style="width:90%;">
										<p align="left">
											<xsl:value-of select="@PROFESSOR"/>
										</p>
									</th>
								</TR>
								<TR>
								<th style="width:10%;">
									<p align="left">Thesis topic</p>
								</th>
								<th style="width:90%;">
									<p align="left">
										<xsl:value-of select="@THESIS_TOPIC"/>
									</p>
								</th>
								</TR>
								<TR>
									<th style="width:10%;">
										<p align="left">Schedule</p>
									</th>
									<th style="width:90%;">
										<p align="left">
											<xsl:value-of select="@SCHEDULE"/>
										</p>
									</th>
								</TR>
								<TR>
								<th style="width:10%;">
									<p align="left">Auxiliary materials</p>
								</th>
								<th style="width:90%;">
									<p align="left">
										<xsl:value-of select="@AUXILIARY_MATERIALS"/>
									</p>
								</th>
								</TR>
								<TR>
									<th style="width:10%;">
										<p align="left">Stage</p>
									</th>
									<th style="width:90%;">
										<p align="left">
											<xsl:value-of select="@STAGE"/>
										</p>
									</th>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</xsl:for-each>
			</TR>
		</TABLE>
	</xsl:template>

</xsl:stylesheet> 