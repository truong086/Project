/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.ui;

import com.btljava.controller.HoaDonController;
import com.btljava.controller.KhoController;
import com.btljava.controller.NhanVienController;
import com.btljava.dao.impl.hoadonDao;
import com.btljava.dao.impl.khoDao;
import com.btljava.helper.MessageDialog;
import com.btljava.helper.ShereData;
import com.btljava.model.hoadon;
import com.btljava.model.kho;
import com.btljava.model.nhanvien;
import java.awt.Color;
import java.util.ArrayList;
import java.util.List;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author ASUS
 */
public class thongkes extends javax.swing.JDialog {
    private DefaultTableModel model;
    private fromMain mains;
    
    private KhoController dao = new KhoController();
    private HoaDonController daos = new HoaDonController();
    private NhanVienController daonv = new NhanVienController();
    /**
     * Creates new form thongkes
     */
    public thongkes(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        
        
    }
    
    private void inittable(){
        model = new DefaultTableModel();
        model.setColumnIdentifiers(new String[] {
            "ID", "Mã bệnh nhân", "Ngày ra", "Phương pháp điều trị", "Miêu tả", "Mã thuốc", "Số lượng", "Tổng tiền thuốc", "Tổng tiền", "Ngày tạo"
        });
        
        tblTable.setModel(model);
    }
    
    private void loadDataTable(){
        try{
//            hoadonDao dao = new hoadonDao();
            List<hoadon> list = daos.sapxxep();
            model.setRowCount(0);
            for(hoadon hd : list){
                model.addRow(new Object[] {
                    hd.getId(), hd.getMabenhnhan(), hd.getNgayra(), hd.getPhuongphapdieutri(), 
                    hd.getMieuta(), hd.getThuoc_id(), hd.getSoluong(), hd.getTongtienthuoc(), hd.getTongtien(), hd.getNgaytao()
                });
            }
            model.fireTableDataChanged();
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }
    
    private void daban(){
        try{
            int sum = 0;
            int tongtien = 0;
//            hoadonDao dao = new hoadonDao();
            List<hoadon> list = daos.findAll();
            for(hoadon hd : list){
                hd.getId();
                hd.getMabenhnhan();
                hd.getNgayra();
                hd.getPhuongphapdieutri();
                hd.getMieuta(); 
                hd.getThuoc_id(); 
                hd.getSoluong(); 
                hd.getTongtienthuoc();
                hd.getTongtien();
                hd.getNgaytao();
                tongtien = hd.getTongtien();
                sum = sum + tongtien;
            }
            
            
//            for(int i = 1; i <= list.size(); i++){
//                sum = sum + tongtien;
//            }
            
            String tong = String.valueOf(sum);
            doanhthu.setText(tong + " Đồng");
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }
    
    private void tonkho(){
        try{
            int tongban = 0;
            int sum = 0;
            int tonkho = 0;
            int soluong = 0;
            int ids = 0;
            int idss = 0;
            String tenthuoc = "";
//            khoDao dao = new khoDao();
            List<kho> list = dao.findAll();
            
            
                for(kho kh : list){
                    kh.getId();
                    kh.getSanpham_id();
                    kh.getSoluong();
                    kh.getSoluongnhap();
                    kh.getDaban();
                    //kh.getTonkho();
                    kh.getNgaytao();

                    
                    tonkho = kh.getTonkho();
                    sum = sum + tonkho;
                    soluong = kh.getDaban();
                    tongban = tongban + soluong;
                }
                
                
                
            
            
//            for(int i = 1; i <= list.size(); i++){
//                    sum = sum + tonkho;
//                    //tongban = tongban + soluong;
//            }
            
            
            
            String tong = String.valueOf(sum);
            String tongdaban = String.valueOf(tongban);
            tonkhos.setText(tong + " Sản phẩm");
            tongmuahang.setText(tongdaban + " Sản phẩm");
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }
    
    private void hienthi(){
        try{
//            int ids = 0;
//            int idss = 0;
            String tenthuoc = "";
            int tong = 0;
            int tongthuoc = 0;
            int soluongnhapTDT = 0;
            int vacxinCovid19 = 0;
            int dabanDT = 0;
            int dabanVc19 = 0;
            int thuoctritatca = 0;
            int soluongnhapTT = 0;
            int tongthuocTT = 0;
//            List<kho> list = dao.findAll();
            List<kho> list = dao.hienthi(1);
            List<kho> list1 = dao.hienthi(3);
            List<kho> list2 = dao.hienthi(4);
//            List<kho> lists = new ArrayList<kho>();
            if(list != null && list1 != null && list2 != null){
                for(kho kh : list){
                    int tonkho = kh.getTonkho();
                    int thuocdactri = kh.getSoluongnhap();
                    int daban = kh.getDaban();
                    thuoc1s.setText(kh.getTensanpham());
                    tong = tong + tonkho;
                    soluongnhapTDT = soluongnhapTDT + thuocdactri;
                    dabanDT = dabanDT + daban;
                }
                for(kho kh : list1){
                    int tonkho = kh.getTonkho();
                    int vaxxinCV19 = kh.getSoluongnhap();
                    int daban = kh.getDaban();
                    String tenthuocs = kh.getTensanpham();
                    thuoc2s.setText(tenthuocs);
                    tongthuoc = tongthuoc + tonkho;
                    vacxinCovid19 = vacxinCovid19 + vaxxinCV19;
                    dabanVc19 = dabanVc19 + daban;
                }
                for(kho kh : list2){
                    int tonkho = kh.getTonkho();
                    int thuoctritt = kh.getSoluongnhap();
                    int daban = kh.getDaban();
                    String tenthuocs = kh.getTensanpham();
                    thuoc3s.setText(tenthuocs);
                    tongthuocTT = tongthuocTT + tonkho;
                    soluongnhapTT = soluongnhapTT + thuoctritt;
                    thuoctritatca = thuoctritatca + daban;
                }
                
                if(tongthuocTT == 0){
                    thuoc3.setText("Hết hàng");
                }else{
                    String tongs = String.valueOf(tongthuocTT);
                    thuoc3.setText(tongs + " Sản phẩm");
                }
                
                if(soluongnhapTT == 0){
                    thuoc3ss.setText("Thuốc chưa được nhập");
                }else{
                    String soluongnhap = String.valueOf(soluongnhapTT);
                    thuoc3ss.setText("Số lượng nhập: " + soluongnhap + " SP");
                }
                
                if(thuoctritatca == 0){
                    thuoc3sss.setText("Chưa bán được");
                }else{
                    String dabans = String.valueOf(thuoctritatca);
                    thuoc3sss.setText("Đã bán: " + dabans + " SP");
                }
//                int tonkho = list.getTonkho();
//                thuoc1s.setText(list.getTensanpham());
//                for(int i = 0; i <= list.getSanpham_id(); i++){
//                    tong = tong + tonkho;
//                }
                
//                int i = 0;
//                while(i <= list.getId()){
//                    tong = tong + tonkho;
//                    i++;
//                }
                if(tong == 0){
                    String tongs = String.valueOf(tong);
                    thuoc1.setText("Hết hàng");
                    
                }else{
                    
                    String tongs = String.valueOf(tong);
                    thuoc1.setText(tongs + " Sản phẩm");
                    
                }
                
                if(soluongnhapTDT == 0){
                    thuoc1ss.setText("Chưa nhập thuốc");
                }else{
                    String soluongnhapTDTs = String.valueOf(soluongnhapTDT);
                    thuoc1ss.setText("Số lượng nhập: " + soluongnhapTDTs + " SP");
                }
                
                
                
                if(tongthuoc == 0){
                    
//                    String tongthuocs  = String.valueOf(tongthuoc);
                    thuoc2.setText("Hết hàng");
                    
                }else{
                    
                    String tongthuocs  = String.valueOf(tongthuoc);
                    thuoc2.setText(tongthuocs + " Sản phẩm");
                    
                }
                
                
                
                if(vacxinCovid19 == 0){
                    thuoc2ss.setText("Chưa nhập thuốc");
                    
                }else{
                    String covid19 = String.valueOf(vacxinCovid19);
                    thuoc2ss.setText("Số lượng nhập: " + covid19 + " SP");
                }
                
                if(dabanDT == 0){
                    thuoc1sss.setText("Chưa bán được");
                }else{
                    String dabans = String.valueOf(dabanDT);
                    thuoc1sss.setText("Đã bán: " + dabanDT + " SP");
                }
                
                if(dabanVc19 == 0){
                    thuoc2sss.setText("Chưa bán được");
                }else{
                    String dabans = String.valueOf(dabanVc19);
                    thuoc2sss.setText("Đã bán: " + dabans + " SP");
                }
                
                
                
                
                
//                if(id == 1){
////                    String tenthuoc = list.getTensanpham();
//                    String ids = String.valueOf(id);
//                    thuoc1s.setText(ids);
//                }
            }
//            for(int i = 0; i < list.size(); i++){
////                ids = list.get(i).getId();
//               
//                if(list.get(i).getId() == 1){
//                    tenthuoc = list.get(i).getTensanpham();
//                    thuoc1s.setText(list.get(i).getTensanpham());
//                }
//            }
//             kho khs = new kho();
//              for(kho kh : list){
//                 int id = kh.getId();
//                  kh.getIds();
//                  kh.getTensanpham();
//                 
//              }
             
              
              
            
             
        }catch(Exception e){
            MessageDialog.showMessageError(this, e.getMessage(), "Lỗi");
        }
        
    }
    
    private void chucvu(){
        try{
            int tong = 0;
            int tongtlYta = 0;
            List<nhanvien> list = daonv.chucvu(12345);
            List<nhanvien> lists = daonv.chucvu(123456);
            if(list != null && lists != null){
                for(nhanvien nv : list){
                    int tienluong = nv.getTienluong();
                    tong = tong + tienluong;
                }
                
                for(nhanvien nv : lists){
                    int tienluong = nv.getTienluong();
                    
                    tongtlYta = tongtlYta + tienluong;
                }
                
                String tongtlYtas = String.valueOf(tongtlYta);
                tienluongs2s.setText(tongtlYtas + " VNĐ");
                
                String tongs = String.valueOf(tong);
                tienluongs.setText(tongs + " VNĐ");
            }
            
        }catch(Exception e){
            MessageDialog.showMessageError(this, e.getMessage(), "Lỗi");
        }
        
        
    }
    
    private void initTable(){
        model = new DefaultTableModel();
        model.setColumnIdentifiers(new String[] {
            "ID", "Mã sản phẩm", "Số lượng", "Số lượng nhập", "Đã bán", "Tồn kho", "Ngày tạo"
        });
        
        tblTable1.setModel(model);
    }
    
    private void loadDataTables(){
        try{
//            khoDao dao = new khoDao();
            List<kho> list = dao.findAll();
            model.setRowCount(0);
            for(kho kh : list){
                model.addRow(new Object[] {
                    kh.getId(), kh.getSanpham_id(), kh.getSoluong(), kh.getSoluongnhap(), kh.getDaban(), kh.getTonkho(), kh.getNgaytao()
                });
            }
            
            model.fireTableDataChanged();
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(this, e.getMessage(), "Lỗi");
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        doanhthu = new javax.swing.JLabel();
        tonkhos = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblTable = new javax.swing.JTable();
        tongmuahang = new javax.swing.JLabel();
        jLabel12 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        tblTable1 = new javax.swing.JTable();
        thuoc1s = new javax.swing.JLabel();
        thuoc1 = new javax.swing.JLabel();
        thuoc2s = new javax.swing.JLabel();
        thuoc2 = new javax.swing.JLabel();
        thuoc3s = new javax.swing.JLabel();
        thuoc3 = new javax.swing.JLabel();
        thuoc1ss = new javax.swing.JLabel();
        thuoc1sss = new javax.swing.JLabel();
        thuoc2sss = new javax.swing.JLabel();
        thuoc3sss = new javax.swing.JLabel();
        thuoc2ss = new javax.swing.JLabel();
        thuoc3ss = new javax.swing.JLabel();
        tienluongs = new javax.swing.JLabel();
        thuoc2s1 = new javax.swing.JLabel();
        thuoc2s2 = new javax.swing.JLabel();
        tienluongs2s = new javax.swing.JLabel();
        quyen = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowOpened(java.awt.event.WindowEvent evt) {
                formWindowOpened(evt);
            }
        });

        doanhthu.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        doanhthu.setText("jLabel2");

        tonkhos.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        tonkhos.setText("jLabel2");

        jButton1.setText("Làm mới");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jLabel1.setText("Tổng số lượng bán trong tháng");

        jLabel3.setText("Doanh thu trong tháng");

        jLabel4.setText("Số lượng tồn kho");

        tblTable.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane1.setViewportView(tblTable);

        tongmuahang.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        tongmuahang.setText("jLabel2");

        jLabel12.setFont(new java.awt.Font("Tahoma", 1, 48)); // NOI18N
        jLabel12.setText("Thống kê");

        tblTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        tblTable1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblTable1MouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(tblTable1);

        thuoc1s.setText("jLabel2");

        thuoc1.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        thuoc1.setText("jLabel5");

        thuoc2s.setText("jLabel2");

        thuoc2.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        thuoc2.setText("jLabel5");

        thuoc3s.setText("jLabel8");

        thuoc3.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        thuoc3.setText("jLabel9");

        thuoc1ss.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        thuoc1ss.setText("jLabel5");

        thuoc1sss.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        thuoc1sss.setText("jLabel5");

        thuoc2sss.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        thuoc2sss.setText("jLabel5");

        thuoc3sss.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        thuoc3sss.setText("jLabel5");

        thuoc2ss.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        thuoc2ss.setText("jLabel5");

        thuoc3ss.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        thuoc3ss.setText("jLabel5");

        tienluongs.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        tienluongs.setText("jLabel5");

        thuoc2s1.setText("Tổng tiền lương của bác sĩ trong bênh viện");

        thuoc2s2.setText("Tổng tiền lương của Y tá trong bệnh viện");

        tienluongs2s.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        tienluongs2s.setText("jLabel5");

        quyen.setText("jButton1");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jScrollPane2)
                        .addContainerGap())
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(40, 40, 40)
                                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 193, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(76, 76, 76)
                                        .addComponent(tongmuahang, javax.swing.GroupLayout.PREFERRED_SIZE, 149, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addGap(41, 41, 41)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel4, javax.swing.GroupLayout.PREFERRED_SIZE, 162, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(tonkhos, javax.swing.GroupLayout.PREFERRED_SIZE, 141, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGap(80, 80, 80)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel12)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addGroup(layout.createSequentialGroup()
                                                .addGap(10, 10, 10)
                                                .addComponent(doanhthu, javax.swing.GroupLayout.PREFERRED_SIZE, 145, javax.swing.GroupLayout.PREFERRED_SIZE))
                                            .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 186, javax.swing.GroupLayout.PREFERRED_SIZE))
                                        .addGap(105, 105, 105)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                            .addComponent(thuoc1, javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(thuoc1sss, javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(thuoc1ss, javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(thuoc1s, javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(thuoc2ss, javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(thuoc2sss, javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(thuoc2s, javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(thuoc2, javax.swing.GroupLayout.Alignment.LEADING)))))
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 751, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 201, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addComponent(tienluongs)
                                .addGap(137, 137, 137))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(thuoc3)
                                        .addComponent(thuoc3ss)
                                        .addComponent(thuoc3sss)
                                        .addComponent(thuoc3s))
                                    .addComponent(thuoc2s1)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(tienluongs2s)
                                        .addGap(59, 59, 59))
                                    .addComponent(thuoc2s2))
                                .addGap(78, 78, 78))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(quyen)
                                    .addComponent(jButton1))
                                .addGap(23, 23, 23))))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel12)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jButton1)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(quyen)))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel4, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 47, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                        .addComponent(doanhthu)
                                        .addComponent(tonkhos, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addComponent(tongmuahang, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 250, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(thuoc3s)
                                    .addComponent(thuoc1s))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(thuoc1)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addGroup(layout.createSequentialGroup()
                                                .addGap(18, 18, 18)
                                                .addComponent(thuoc3ss)
                                                .addGap(31, 31, 31)
                                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                                    .addComponent(thuoc1sss)
                                                    .addComponent(thuoc3sss, javax.swing.GroupLayout.PREFERRED_SIZE, 22, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                            .addGroup(layout.createSequentialGroup()
                                                .addGap(21, 21, 21)
                                                .addComponent(thuoc1ss))))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(thuoc3)
                                        .addGap(93, 93, 93)))
                                .addGap(64, 64, 64)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(thuoc2s)
                                        .addGap(38, 38, 38))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(thuoc2s1)
                                        .addGap(18, 18, 18)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                            .addComponent(thuoc2)
                                            .addComponent(tienluongs))
                                        .addGap(2, 2, 2)))
                                .addGap(14, 14, 14)
                                .addComponent(thuoc2ss)))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 19, Short.MAX_VALUE)
                        .addComponent(thuoc2sss)
                        .addGap(12, 12, 12))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(thuoc2s2)
                        .addGap(18, 18, 18)
                        .addComponent(tienluongs2s)
                        .addGap(18, 18, 18)))
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 302, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
        loadDataTable();
        daban();
        tonkho();
        loadDataTables();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void checkLogin(){
        int phanquyen = ShereData.dangnhapss.getPhanquyen();
        if(phanquyen == 1){
            quyen.setForeground(Color.red);
            quyen.setText("Admin");
        }
        if(phanquyen == 2){
            quyen.setForeground(Color.red);
            quyen.setText("Quản lý");
        }
        if(phanquyen == 3){
            quyen.setForeground(Color.red);
            quyen.setText("Bệnh nhân");
        }
    }
    private void formWindowOpened(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowOpened
        // TODO add your handling code here:
        inittable();
        
        loadDataTable();
        
        daban();
        
        tonkho();
        
        initTable();
        loadDataTables();
        
        hienthi();
        
        chucvu();
        checkLogin();
    }//GEN-LAST:event_formWindowOpened

    private void tblTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblTable1MouseClicked
        // TODO add your handling code here:

        //        try{
            //            int row = tblTable.getSelectedRow();
            //            if(row >= 0){
                //                ids = (int) tblTable.getValueAt(row, 0);
                //                khoDao dao = new khoDao();
                //                kho list = dao.findAllid(ids);
                //                String sanphamid = String.valueOf(list.getSanpham_id());
                //                String soluong = String.valueOf(list.getSoluong());
                //                String soluongnhap = String.valueOf(list.getSoluongnhap());
                //                String daban = String .valueOf(list.getDaban());
                //                String tonkho = String.valueOf(list.getTonkho());
                //                if(list != null){
                    //                    masanphams.setText(sanphamid);
                    //                    soluongs.setText(soluong);
                    //                    soluongnhaps.setText(soluongnhap);
                    //                    dabans.setText(daban);
                    //                    tonkhos.setText(tonkho);
                    //                    ngaytaos.setText(list.getNgaytao());
                    //                }
                //            }
            //        }catch(Exception e){
            //            e.printStackTrace();
            //            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
            //        }
    }//GEN-LAST:event_tblTable1MouseClicked

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(thongkes.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(thongkes.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(thongkes.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(thongkes.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                thongkes dialog = new thongkes(new javax.swing.JFrame(), true);
                dialog.addWindowListener(new java.awt.event.WindowAdapter() {
                    @Override
                    public void windowClosing(java.awt.event.WindowEvent e) {
                        System.exit(0);
                    }
                });
                dialog.setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel doanhthu;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JButton quyen;
    private javax.swing.JTable tblTable;
    private javax.swing.JTable tblTable1;
    private javax.swing.JLabel thuoc1;
    private javax.swing.JLabel thuoc1s;
    private javax.swing.JLabel thuoc1ss;
    private javax.swing.JLabel thuoc1sss;
    private javax.swing.JLabel thuoc2;
    private javax.swing.JLabel thuoc2s;
    private javax.swing.JLabel thuoc2s1;
    private javax.swing.JLabel thuoc2s2;
    private javax.swing.JLabel thuoc2ss;
    private javax.swing.JLabel thuoc2sss;
    private javax.swing.JLabel thuoc3;
    private javax.swing.JLabel thuoc3s;
    private javax.swing.JLabel thuoc3ss;
    private javax.swing.JLabel thuoc3sss;
    private javax.swing.JLabel tienluongs;
    private javax.swing.JLabel tienluongs2s;
    private javax.swing.JLabel tongmuahang;
    private javax.swing.JLabel tonkhos;
    // End of variables declaration//GEN-END:variables
}
