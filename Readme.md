TreeListView1을 빌드하면 재대로 바인드가 되지만,
TreeListView2를 빌드하면 바인드가 재대로 안됩니다...


TreeListView1 는 TreeListView1.xaml.cs 에서 28, 29줄에서
DataContext안에 myScheduleItem를 넣었고


[28]    this.DataContext = 

[29]    new myScheduleItem



TreeListView2 는 TreeListView2.xaml.cs 에서 29줄에서 현재 유저컨트롤을 DataContext화 시키고,
23줄에서 myScheduleItem 의 멤버변수를 줘서 초기화 시켰습니다.

[23]    public myScheduleItem sc { get; set; }

[29]    this.DataContext = this;

[30]    sc = 

[31]    new myScheduleItem



그리고 당연히도 TreeListView2.xaml에서는
모든 바인딩의 {Binding sc.SubItems} 이런식으로 sc.* 을 추가했습니다.


TreeListView1 에서 TreeListView2 형식으로 넘어가고싶습니다.