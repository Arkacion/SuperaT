
<HTML>
    <HEAD>
        <TITLE>SuperaT</TITLE>

    </HEAD>
    <HEADER><H1> Estadisticas </H1></HEADER>
    <BODY>	
       <?php
			$server = "localhost";
			$user = "root";
			$pass = "";
			$database = "superat";

			$connect = new mysqli($server, $user, $pass, $database);

			if (!$connect) {
				echo "ERROR";
			} else {
				$sql = "SELECT * FROM description ORDER BY date;";
				$result = mysqli_query($connect, $sql);

				if(mysqli_num_rows($result) > 0){
					
					echo '
					<table width="70%" border="1px" align="center">

					<tr align="center">
				        <td>Date</td>
				        <td>DNI</td>
				        <td>Fobia</td>
				        <td>Max</td>
				        <td>Min</td>
				        <td>Difference</td>
				        <td>seconds 01</td>
				        <td>seconds 02</td>
				        <td>seconds 03</td>
				        <td>seconds 04</td>
				        <td>seconds 05</td>
				        <td>seconds 06</td>
				        <td>seconds 07</td>
				        <td>seconds 08</td>
				        <td>seconds 09</td>
				        <td>seconds 10</td>
				        <td>seconds 11</td>
				        <td>seconds 12</td>
				        <td>seconds 13</td>
				        <td>seconds 14</td>
				        <td>seconds 15</td>
				        <td>seconds 16</td>
				        <td>seconds 17</td>
				        <td>seconds 18</td>
				        <td>seconds 19</td>
				        <td>seconds 20</td>
				        <td>seconds 21</td>
				        <td>seconds 22</td>
				        <td>seconds 23</td>
				        <td>seconds 24</td>
				        <td>seconds 25</td>
				        <td>seconds 26</td>
				        <td>seconds 27</td>
				        <td>seconds 28</td>
				        <td>seconds 29</td>
				        <td>seconds 30</td>
				        <td>Time</td>
			    	</tr>';

					$i=0;
					while ($row = mysqli_fetch_assoc($result)) {
						
						if ($i%2 == 0){
							echo '<tr bgcolor="#819FF7">';
						}else {
							echo '<tr>';
						}
							
							echo '<td>'.$row['date'].'</td>';
							echo '<td>'.$row['dni_pacient'].'</td>';
							echo '<td>'.$row['phobia'].'</td>';
							echo '<td>'.$row['max'].'</td>';
							echo '<td>'.$row['min'].'</td>';
							echo '<td>'.$row['deff_max_min'].'</td>';
							echo '<td>'.$row['s_01'].'</td>';
							echo '<td>'.$row['s_02'].'</td>';
							echo '<td>'.$row['s_03'].'</td>';
							echo '<td>'.$row['s_04'].'</td>';
							echo '<td>'.$row['s_05'].'</td>';
							echo '<td>'.$row['s_06'].'</td>';
							echo '<td>'.$row['s_07'].'</td>';
							echo '<td>'.$row['s_08'].'</td>';
							echo '<td>'.$row['s_09'].'</td>';
							echo '<td>'.$row['s_10'].'</td>';
							echo '<td>'.$row['s_11'].'</td>';
							echo '<td>'.$row['s_12'].'</td>';
							echo '<td>'.$row['s_13'].'</td>';
							echo '<td>'.$row['s_14'].'</td>';
							echo '<td>'.$row['s_15'].'</td>';
							echo '<td>'.$row['s_16'].'</td>';
							echo '<td>'.$row['s_17'].'</td>';
							echo '<td>'.$row['s_18'].'</td>';
							echo '<td>'.$row['s_19'].'</td>';
							echo '<td>'.$row['s_20'].'</td>';
							echo '<td>'.$row['s_21'].'</td>';
							echo '<td>'.$row['s_22'].'</td>';
							echo '<td>'.$row['s_23'].'</td>';
							echo '<td>'.$row['s_24'].'</td>';
							echo '<td>'.$row['s_25'].'</td>';
							echo '<td>'.$row['s_26'].'</td>';
							echo '<td>'.$row['s_27'].'</td>';
							echo '<td>'.$row['s_28'].'</td>';
							echo '<td>'.$row['s_29'].'</td>';
							echo '<td>'.$row['s_30'].'</td>';
							echo '<td>'.$row['time'].'</td>';
						echo '</tr>';
						$i++;
					}
					

				} else { echo "401";}
			}
		?>
    </BODY>
</HTML>
