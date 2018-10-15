
export STATUS=0
i=0
while [[ $STATUS -eq 0 ]] || [[ $i -lt 30 ]]; do
	sleep 1
	i=$i+1
	STATUS=$(grep 'Server setup is completed' /var/opt/mssql/log/setup*.log | wc -l)
done