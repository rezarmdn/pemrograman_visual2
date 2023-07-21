
<?php
require_once 'database.php';
require_once 'Tb_kendaraan.php';
$db = new MySQLDatabase();
$tb_kendaraan = new Tb_kendaraan($db);
$id=0;
$nama=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['nama'])){
            $nama = $_GET['nama'];
        }
        if($id>0){    
            $result = $tb_kendaraan->get_by_id($id);
        }elseif($nama>0){
            $result = $tb_kendaraan->get_by_nama($nama);
        } else {
            $result = $tb_kendaraan->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new tb_kendaraan
        $tb_kendaraan->nama = $_POST['nama'];
        $tb_kendaraan->daya_angkut = $_POST['daya_angkut'];
        $tb_kendaraan->harga = $_POST['harga'];
        $tb_kendaraan->id_rute = $_POST['id_rute'];
       
        $tb_kendaraan->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Tb_kendaraan created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Tb_kendaraan not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['nama'])){
            $nama = $_GET['nama'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $tb_kendaraan->nama = $_PUT['nama'];
        $tb_kendaraan->daya_angkut = $_PUT['daya_angkut'];
        $tb_kendaraan->harga = $_PUT['harga'];
        $tb_kendaraan->id_rute = $_PUT['id_rute'];
        if($id>0){    
            $tb_kendaraan->update($id);
        }elseif($nama<>""){
            $tb_kendaraan->update_by_nama($nama);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Tb_kendaraan updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Tb_kendaraan update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['nama'])){
            $nama = $_GET['nama'];
        }
        if($id>0){    
            $tb_kendaraan->delete($id);
        }elseif($nama>0){
            $tb_kendaraan->delete_by_nama($nama);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Tb_kendaraan deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Tb_kendaraan delete failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
    }
$db->close()
?>