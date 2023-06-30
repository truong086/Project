<?php
    // Tạo cookie
    setcookie("msg", "Hello World", time() + 7*24*60*60, "/"); 
    // "time()" là thời gian server trả về và cộng với 30 giây là thời gian quá hạn, sau 30 giây sẽ bị xóa
    // Lưu ý: Thời gian quá hạn có thể sửa thành bao lâu cũng được
    // Dấu "/" này là đường dẫn, thông thường ở công đoạn này chỉ nên cho dấu "/" này thôi, nghĩa là nó sẽ gắn với tất cả URL tên miền của chúng ta
    // "msg" là tên và "Hello World" là giá trị, "setcookie" phải truyền 2 tham số là tên và giá trị

    setcookie("status", "test", time() + 7*24*60*60, "/");
    // "7*24*60*60" đây là định dạng thời gian quá hạn trong 1 tuần
    // "status" là tên và "test" là giá trị, "setcookie" phải truyền 2 tham số là tên và giá trị
?>