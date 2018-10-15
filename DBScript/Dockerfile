FROM microsoft/mssql-server-linux:latest
RUN mkdir -p /usr/config
WORKDIR /usr/config
EXPOSE 33684
EXPOSE 443
EXPOSE 1433
#RUN dotnet restore
#RUN dotnet publish -c Release -o output

#FROM microsoft/dotnet:2.1-aspnetcore-runtime
#WORKDIR /app
# Bundle config source
COPY . /usr/config
#COPY entrypoint.sh entrypoint.sh
#COPY SqlCmdStartup.sh SqlCmdStartup.sh
#COPY 01-createSpeakerTable.sql 01-createSpeakerTable.sql
#COPY 02-createSponsorTable.sql 02-createSponsorTable.sql
RUN chmod +x /usr/config/SqlCmdStartup.sh
RUN chmod +x /usr/config/entrypoint.sh 
#CMD [ "/opt/mssql/bin/sqlservr" ]
ENTRYPOINT ["/bin/bash","./entrypoint.sh"]
# Tail the setup logs to trap the process
CMD ["tail -f /dev/null"]

HEALTHCHECK --interval=15s CMD /opt/mssql-tools/bin/sqlcmd -U sa -P Your_password123 -Q "select 1" && grep -q "MSSQL CONFIG COMPLETE" ./config.log
#CMD /bin/bash entrypoint.sh

#CMD ["dotnet","ConferenceApp.dll"]
