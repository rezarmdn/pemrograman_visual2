
<?php
//Simpanlah dengan nama file : Tiket2.php
require_once 'database.php';
class Tiket2 
{
    private $db;
    private $table = 'tiket2';
    public $Notiket = "";
    public $Nama = "";
    public $Nohp = "";
    public $tujuan = "";
    public $harga = "";
    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    public function get_all() 
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function get_by_Notiket(int $Notiket)
    {
        $query = "SELECT * FROM $this->table WHERE Notiket = $Notiket";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`Notiket`,`Nama`,`Nohp`,`tujuan`,`harga`) VALUES ('$this->Notiket','$this->Nama','$this->Nohp','$this->tujuan','$this->harga')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET Notiket = '$this->Notiket', Nama = '$this->Nama', Nohp = '$this->Nohp', tujuan = '$this->tujuan', harga = '$this->harga' 
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_Notiket($Notiket): int
    {
        $query = "UPDATE $this->table SET Notiket = '$this->Notiket', Nama = '$this->Nama', Nohp = '$this->Nohp', tujuan = '$this->tujuan', harga = '$this->harga' 
        WHERE Notiket = $Notiket";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_Notiket($Notiket): int
    {
        $query = "DELETE FROM $this->table WHERE Notiket = $Notiket";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>