export STATUS=1
i=0
while [[ $STATUS -ne 0 ]] && [[ $i -lt 30 ]]; do
	i=$i+1
	/opt/mssql-tools/bin/sqlcmd -t 1 -U sa -P Your_password123 -Q "select 1" >> /dev/null
	STATUS=$?
done
if [ $STATUS -ne 0 ]; then 
	echo "Error: MSSQL SERVER took more than thirty seconds to start up."
	exit 1
fi
echo "======= MSSQL SERVER STARTED ========" | tee -a ./config.log
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Your_password123 -d master -i /usr/config/01-createSpeakerTable.sql
echo "======= MSSQL CONFIG COMPLETE =======" | tee -a ./config.log