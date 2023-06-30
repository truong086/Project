/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.hoadon;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface IHoaDonService {
    public boolean insert(hoadon hd) throws Exception;
    
    public boolean update(hoadon hd) throws Exception;
    
    public boolean delete(String hd) throws Exception;
    
    public List<hoadon> findAll() throws Exception;
    
    public List<hoadon> timkiem(String s) throws Exception;
    
    public hoadon findbyid(int s) throws Exception;
    public List<hoadon> khachhang(String s) throws Exception;
    
    public List<hoadon> sapxxep() throws Exception;
}
