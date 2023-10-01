# Railway_Project-FRMCS_Simulation
Real time visualization of Trains, Signals, Tracks and Level crossings using FRMCS technology for Indian Railways <br>
##Installation detials
  clone this repository using github desktop app
  go to file>clone repository>Raizelen/Railway_Project-FRMCS_Simulation <br>
-set local path to desired location (its better keep in drive with bigger size as project grows unity will genereate some temperory files that take up space)<br>
-open Unity Hub in install tab make sure version is set to LTS 2022.3.10f1<br>
-go to project open button on upper right corner and locate the cloned repository you did earlier using github desktop app<br>
-it will open project in unity and will automatically added to project list on Unity Hub<br>
## Loco Pilot Scenario

### Assumptions
Train station #1: Thrissur
Train station #2: OLLUR
Train : Kasaragod Trivandrum Parasuram express on platform # 1 going towards Ernakulam
Two manual level crossings
Signaling systems : Multi aspect signaling system using “Block Control” or “Multiple Axle counting” method. 

#### Scene 1: Thrissur Station - Pre-Boarding
●	Wide shot of Thrissur Railway Station, platform #1, with the Kasargod Trivandrum Parasuram express train parked
●	Zoom in to the train engine, loco pilot's cabin
●	Loco pilot approaches the engine
●	Close-up of loco pilot's view of the Display Unit
#### Scene 2 Loco Pilot's Dashboard - Pre-Departure
●	Display Unit on the dashboard flashes 
●	Display console shows RED signal on the Top Right side (along with a Label Signal View) corresponding to the real time signal status
●	Loco pilot checks the Display Unit, confirming the RED signal
●	Display transitions from RED to GREEN signal
●	Loco pilot blows the horn
●	Loco pilot releases the brakes and the train starts moving

#### Scene 3: Real-Time Display - Departure
●	Close-up of the Display Unit showing GREEN signal for the upcoming block
●	When the train enters the next "BLOCK" the corresponding signal turns Red in the pilot's console with a lag as per the Railway SoP. 
●	Block IDs before and after the train within the loco pilot's  Geo fence should be clearly visible along with their real-time signal status as the train moves from block to block
●	View of the track side LTE-R communication towers passing by is shown with labels

#### Scene 4: Level Crossing #1 Approach - Display Information
●	Text overlay: "2 km to Level Crossing #1"
●	Display Unit updates, showing the upcoming level crossing and the LC signal status corresponding to road view turns RED on the Loco Pilot console on the Top Left side (along with a Label LC View) to demonstrate to the loco pilot that it is safe to pass through at full speed. 
●	Loco pilot sees the Level Crossing #1 status turning YELLOW on the Display Unit as the train crosses the LC #1 
●	Signal status corresponding to LC #1 changes to GREEN as the train moves ahead as per the Railway SoP
●	Block signals continue to be shown as train enters and leaves each block
●	Track side LTE-R Mobile towers will also be shown continuously
#### Scene 5: Approaching Ollur Station 
●	View of the simulated platform tracks on the Loco Pilots control panel. A train parked on the platform #2 can be explicitly seen (with flashing icon) by the Loco Pilot along with flashing RED signal (Top Right) on the occupied track
●	Real time signal status before and after the train within the train Geo fence are also continuously visible 
●	Station Master/ Station Control Room directs the train into platform #1 at Ollur station
●	Train rolls into Ollur Station and stops at the end
●	Block Signal in front of the loco pilot is RED, visible on the Display Unit
#### Scene 6: Cab Radio Communication - Display Update
●	Loco pilot uses Cab radio to communicate with the station master with voice over
●	Text overlay: "Communication via LTE-R / 5G / FRMCS"
●	Display Unit shows the communication interfaces inside and outside the Train engine
●	[Display updates with the communication status]



